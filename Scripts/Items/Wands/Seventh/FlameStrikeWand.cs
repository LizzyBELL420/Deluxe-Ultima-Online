using Server.Spells.Seventh;

namespace Server.Items
{
    public class FlameStrikeWand : BaseWand
    {
        [Constructable]
        public FlameStrikeWand() : base(5)
        {
            ItemID = 0xdf4;
            Name = "Flame Strike";
        }

        public FlameStrikeWand(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override void OnWandUse(Mobile from)
        {
            Cast(new FlameStrikeSpell(from, this));
        }
    }
}