using Server.Spells.Third;

namespace Server.Items
{
    public class BlessWand : BaseWand
    {
        [Constructable]
        public BlessWand() : base(13)
        {
            ItemID = 0xdf2;
            Name = "Bless";
        }

        public BlessWand(Serial serial)
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
            Cast(new BlessSpell(from, this));
        }
    }
}