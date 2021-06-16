
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////

namespace Server.Items
{
	public class SandCastleAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SandCastleAddonDeed();
			}
		}

		[ Constructable ]
		public SandCastleAddon()
		{



			AddComplexComponent( (BaseAddon) this, 194, -2, -1, 0, 0, -1, "sandbox", 1);// 1
			AddComplexComponent( (BaseAddon) this, 194, 2, -1, 0, 0, -1, "sandbox", 1);// 2
			AddComplexComponent( (BaseAddon) this, 193, 2, -2, 0, 0, -1, "sandbox", 1);// 3
			AddComplexComponent( (BaseAddon) this, 193, 1, -2, 0, 0, -1, "sandbox", 1);// 4
			AddComplexComponent( (BaseAddon) this, 193, 0, -2, 0, 0, -1, "sandbox", 1);// 5
			AddComplexComponent( (BaseAddon) this, 193, -1, -2, 0, 0, -1, "sandbox", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1340, -1, -1, 0, 51, -1, "sand", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1340, 0, -1, 0, 51, -1, "sand", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1340, 1, -1, 0, 51, -1, "sand", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1341, 2, -1, 0, 51, -1, "sand", 1);// 10
			AddComplexComponent( (BaseAddon) this, 8938, 1, 1, 8, 51, -1, "sand castle", 1);// 11
			AddComplexComponent( (BaseAddon) this, 8934, 2, 2, 8, 51, -1, "sand castle", 1);// 12
			AddComplexComponent( (BaseAddon) this, 194, -2, 0, 0, 0, -1, "sandbox", 1);// 13
			AddComplexComponent( (BaseAddon) this, 193, -1, 2, 0, 0, -1, "sandbox", 1);// 14
			AddComplexComponent( (BaseAddon) this, 8937, 2, 1, 8, 51, -1, "sand castle", 1);// 15
			AddComplexComponent( (BaseAddon) this, 193, 0, 2, 0, 0, -1, "sandbox", 1);// 16
			AddComplexComponent( (BaseAddon) this, 193, 2, 2, 0, 0, -1, "sandbox", 1);// 17
			AddComplexComponent( (BaseAddon) this, 194, 2, 1, 0, 0, -1, "sandbox", 1);// 18
			AddComplexComponent( (BaseAddon) this, 194, 2, 2, 0, 0, -1, "sandbox", 1);// 19
			AddComplexComponent( (BaseAddon) this, 8939, 0, 1, 8, 51, -1, "sand castle", 1);// 20
			AddComplexComponent( (BaseAddon) this, 8942, 0, 0, 8, 51, -1, "sand castle", 1);// 21
			AddComplexComponent( (BaseAddon) this, 194, 2, 0, 0, 0, -1, "sandbox", 1);// 22
			AddComplexComponent( (BaseAddon) this, 8936, 0, 2, 8, 51, -1, "sand castle", 1);// 23
			AddComplexComponent( (BaseAddon) this, 193, 1, 2, 0, 0, -1, "sandbox", 1);// 24
			AddComplexComponent( (BaseAddon) this, 8941, 1, 0, 8, 51, -1, "sand castle", 1);// 25
			AddComplexComponent( (BaseAddon) this, 194, -2, 1, 0, 0, -1, "sandbox", 1);// 26
			AddComplexComponent( (BaseAddon) this, 8940, 2, 0, 8, 51, -1, "sand castle", 1);// 27
			AddComplexComponent( (BaseAddon) this, 8935, 1, 2, 8, 51, -1, "sand castle", 1);// 28
			AddComplexComponent( (BaseAddon) this, 194, -2, 2, 0, 0, -1, "sandbox", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1341, -1, 0, 0, 51, -1, "sand", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1341, -1, 1, 0, 51, -1, "sand", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1341, -1, 2, 0, 51, -1, "sand", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1339, 0, 0, 0, 51, -1, "sand", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1342, 0, 1, 0, 51, -1, "sand", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1342, 0, 2, 0, 51, -1, "sand", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1340, 1, 0, 0, 51, -1, "sand", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1340, 1, 1, 0, 51, -1, "sand", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1339, 1, 2, 0, 51, -1, "sand", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1341, 2, 0, 0, 51, -1, "sand", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1342, 2, 1, 0, 51, -1, "sand", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1340, 2, 2, 0, 51, -1, "sand", 1);// 41

		}

		public SandCastleAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class SandCastleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SandCastleAddon();
			}
		}

		[Constructable]
		public SandCastleAddonDeed()
		{
			Name = "Sand Castle Deed";
		}

		public SandCastleAddonDeed( Serial serial ) : base( serial )
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