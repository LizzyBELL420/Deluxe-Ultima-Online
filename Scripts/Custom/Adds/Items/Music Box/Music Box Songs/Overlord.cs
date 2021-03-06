namespace Server.Items.MusicBox
{
    public class OverlordSong : MusicBoxTrack
    {
        [Constructable]
        public OverlordSong()
            : base(1075173)
        {
            Song = MusicName.BTCastle;
            //Name = "OverlordSong";
        }

        public OverlordSong(Serial s)
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


