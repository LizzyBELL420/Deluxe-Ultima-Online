namespace Server.Items.MusicBox
{
    public class Tavern1Song : MusicBoxTrack
    {
        [Constructable]
        public Tavern1Song()
            : base(1075164)
        {
            Song = MusicName.Tavern01;
            //Name = "Tavern 1";
        }

        public Tavern1Song(Serial s)
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


