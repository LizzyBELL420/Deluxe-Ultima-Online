namespace Server.Items.MusicBox
{
    public class CoveSong : MusicBoxTrack
    {
        [Constructable]
        public CoveSong()
            : base(1075176)
        {
            Song = MusicName.Cove;
            //Name = "CoveSong";
        }

        public CoveSong(Serial s)
            : base(s)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}


