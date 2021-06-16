namespace Server.Items
{
	public class BlueFish : Food
	{
		[Constructable]
		public BlueFish() : base( 15102 )
		{
			Weight = 0.1;
            Stackable = false;
			FillFactor = 3;
			Name = "Blue fish";
		}

		public BlueFish( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}