namespace Server.Items
{
	public class Shrimp : Food
	{
		[Constructable]
		public Shrimp() : base( 15124 )
		{
			Weight = 0.1;
            Stackable = false;
			FillFactor = 3;
			Name = "Shrimp";
		}

		public Shrimp( Serial serial ) : base( serial )
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