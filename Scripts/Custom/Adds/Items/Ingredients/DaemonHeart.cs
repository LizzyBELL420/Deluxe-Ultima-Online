namespace Server.Items
{
	public class DaemonHeart : Item
	{
		[Constructable]
		public DaemonHeart() : this( 1 )
		{
		}

		[Constructable]
        public DaemonHeart(int amount): base(0xF91)
		{
			Name = "Daemon's heart";
            Hue = 1171;
            Stackable = true;
            Amount = amount;
		}

        public override void OnSingleClick(Mobile from)
        {
            {
                if (Amount > 1)
                    LabelTo(from, Amount + " Daemons' hearts");
                else
                    LabelTo(from, "Daemon's heart");
            }
        }

        public DaemonHeart(Serial serial)
            : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            return;
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
	}
}