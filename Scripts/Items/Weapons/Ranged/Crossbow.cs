using System;

namespace Server.Items
{
	[Flipable( 0xF50, 0xF4F )]
	public class Crossbow : BaseRanged
	{
		public override int EffectID{ get{ return 0x1BFE; } }
		public override Type AmmoType{ get{ return typeof( Bolt ); } }
		public override BaseAmmo Ammo { get{ return new Bolt(); } }

		////public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
		//public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 35; } }
		public override int AosMinDamage{ get{ return 18; } }
        public override int AosMaxDamage { get { return Core.ML ? 22 : 20; } }
        public override int AosSpeed { get { return 24; } }

		public override int OldStrengthReq{ get{ return 30; } }
		public override int OldMinDamage{ get{ return 14; } }
		public override int OldMaxDamage{ get{ return 30; } }
		public override int OldSpeed{ get{ return 418; } }

		public override int DefMaxRange{ get{ return 8; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 80; } }

        public override WeaponAnimation DefAnimation { get { return WeaponAnimation.ShootXBow; } }

		[Constructable]
		public Crossbow() : base( 0xF50 )
		{
			Weight = 7.0;
			Layer = Layer.TwoHanded;
			//Name = "crossbow";
		}

		public Crossbow( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

            if (version == 0)
            {
                MinDamage = 14;
                MaxDamage = 30;
            }
		}
	}
}
