namespace Server.Items.MusicBox
{
    public class TurfinSong : MusicBoxTrack
    {
        [Constructable]
        public TurfinSong()
            : base(1075142)
        {
            Song = MusicName.OldUlt02;
            //Name = "TurfinSong";
        }

        public TurfinSong(Serial s)
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


