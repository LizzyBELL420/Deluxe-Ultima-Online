namespace Server.Items.MusicBox
{
    public class AmbrosiaSong : MusicBoxTrack
    {
        [Constructable]
        public AmbrosiaSong()
            : base(1075152)
        {
            Song = MusicName.Samlethe;
            //Name = "AmbrosiaSong";
        }

        public AmbrosiaSong(Serial s)
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


