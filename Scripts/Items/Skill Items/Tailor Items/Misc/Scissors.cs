using Server.Targeting;

namespace Server.Items
{
	public interface IScissorable
	{
		bool Scissor( Mobile from, Scissors scissors );
	}

	[Flipable( 0xf9f, 0xf9e )]
	public class Scissors : Item
	{
		[Constructable]
		public Scissors() : base( 0xF9F )
		{
			Weight = 1.0;
		}

		public Scissors( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void OnDoubleClick( Mobile from )
		{
			from.SendLocalizedMessage( 502434 ); // What should I use these scissors on?

			from.Target = new InternalTarget( this );
		}

		private class InternalTarget : Target
		{
			private readonly Scissors m_Item;

            public InternalTarget(Scissors item) : base(2, false, TargetFlags.None)
            {
				m_Item = item;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
                if (m_Item.Deleted)
                    return;

				if(targeted == from )
				{
                    if (from.HairItemID == 5147 || from.HairItemID == 7947)
                        return;

				    from.FacialHairItemID = 0;
				    from.HairItemID = 0;

                    from.PlaySound(0x248);
				    return;
     			}
                if (targeted is Item && !((Item)targeted).Movable)
                {
                    if (targeted is IScissorable && (targeted is PlagueBeastInnard || targeted is PlagueBeastMutationCore))
                    {
                        IScissorable obj = (IScissorable)targeted;

                        if (obj.Scissor(from, m_Item))
                            from.PlaySound(0x248);
                    }
                }
				if( targeted is IScissorable )
				{
                    if (targeted is Item)
                    {
                        Item item = (Item)targeted;
                        if (item.LootType == LootType.Newbied || item.LootType == LootType.Blessed)
                        {
                            from.SendAsciiMessage("You cannot cut up newbied items");
                            return;
                        }
                    }

					IScissorable obj = (IScissorable)targeted;

					if( obj.Scissor( from, m_Item ) )
						from.PlaySound( 0x248 );
				}
				else
				{
					from.SendLocalizedMessage( 502440 ); // Scissors can not be used on that to produce anything.
				}
			}

            protected override void OnNonlocalTarget(Mobile from, object targeted)
            {
                if (targeted is IScissorable && (targeted is PlagueBeastInnard || targeted is PlagueBeastMutationCore))
                {
                    IScissorable obj = (IScissorable)targeted;

                    if (obj.Scissor(from, m_Item))
                        from.PlaySound(0x248);
                }
                else
                    base.OnNonlocalTarget(from, targeted);
            }
		}
	}
}