namespace Server.Items.MusicBox
{
    public class PubTuneSong : MusicBoxTrack
    {
        [Constructable]
        public PubTuneSong()
            : base(1075167)
        {
            Song = MusicName.Tavern04;
            //Name = "Pub Tune";
        }

        public PubTuneSong(Serial s)
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


