/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
namespace Server.Items
{
	public class OrnatechairSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OrnatechairSAddonDeed();
			}
		}

		[ Constructable ]
		public OrnatechairSAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1113 );
			ac.Hue = 46;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1113 );
			ac.Hue = 46;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 11727 );
			ac.Hue = 46;
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 11727 );
			ac.Hue = 46;
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 11728 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 11728 );
			ac.Hue = 46;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 11504 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 11504 );
			ac.Hue = 46;
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 11210 );
			ac.Hue = 46;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 5036 );
			ac.Hue = 46;
			AddComponent( ac, 1, 1, 4 );

		}

		public OrnatechairSAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class OrnatechairSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OrnatechairSAddon();
			}
		}

		[Constructable]
		public OrnatechairSAddonDeed()
		{
			Name = "OrnatechairS";
		}

		public OrnatechairSAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}