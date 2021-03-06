namespace Server.Items.MusicBox
{
    public class TrinsicPositiveSong : MusicBoxTrack
    {
        [Constructable]
        public TrinsicPositiveSong()
            : base(1075155)
        {
            Song = MusicName.Trinsic;
            //Name = "Trinsic (Positive)";
        }

        public TrinsicPositiveSong(Serial s)
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


