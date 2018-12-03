// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;
using osu.Framework.Configuration;
using osu.Game.Beatmaps;
using osu.Game.Users;

namespace osu.Game.Online.Multiplayer
{
    public class Room
    {
        public Bindable<string> Name = new Bindable<string>("My awesome room!");
        public Bindable<User> Host = new Bindable<User>();
        public Bindable<RoomStatus> Status = new Bindable<RoomStatus>(new RoomStatusOpen());
        public Bindable<RoomAvailability> Availability = new Bindable<RoomAvailability>();
        public Bindable<GameType> Type = new Bindable<GameType>(new GameTypeVersus());
        public Bindable<BeatmapInfo> Beatmap = new Bindable<BeatmapInfo>();
        public Bindable<int?> MaxParticipants = new Bindable<int?>();
        public Bindable<IEnumerable<User>> Participants = new Bindable<IEnumerable<User>>();
    }
}
