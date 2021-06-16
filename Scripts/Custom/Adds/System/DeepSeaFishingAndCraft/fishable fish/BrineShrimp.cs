namespace Server.Items
{
	public class BrineShrimp : Food
	{
		[Constructable]
		public BrineShrimp() : base( 15121 )
		{
			Weight = 0.1;
            Stackable = false;
			FillFactor = 3;
			Name = "Brine shrimp";
		}

		public BrineShrimp( Serial serial ) : base( serial )
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