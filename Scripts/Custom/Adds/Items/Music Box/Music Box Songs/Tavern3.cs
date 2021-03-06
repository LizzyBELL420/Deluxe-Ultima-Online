namespace Server.Items.MusicBox
{
    public class Tavern3Song : MusicBoxTrack
    {
        [Constructable]
        public Tavern3Song()
            : base(1075166)
        {
            Song = MusicName.Tavern03;
            //Name = "Tavern 3";
        }

        public Tavern3Song(Serial s)
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


