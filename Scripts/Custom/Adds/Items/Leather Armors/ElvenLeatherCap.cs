namespace Server.Items
{
	[Flipable( 0x1db9, 0x1dba )]
	public class ElvenLeatherCap : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 4; } }
		public override int BaseColdResistance{ get{ return 3; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 3; } }

		public override int InitMinHits{ get{ return 60; } }
		public override int InitMaxHits{ get{ return 70; } }

		public override int AosStrReq{ get{ return 20; } }
		public override int OldStrReq{ get{ return 15; } }

		public override int ArmorBase{ get{ return 39; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public ElvenLeatherCap() : base( 0x1DB9 )
		{
			Weight = 2.0;
            Name = "Magical Elven Leather Cap";
            Hue = 2549;
            BaseArmorRating = 39;
		}

		public ElvenLeatherCap( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}