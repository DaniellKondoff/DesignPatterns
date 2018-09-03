﻿namespace Facade
{
    public interface IPlayer
    {
        void Play();

        void Stop();

        void Load(MediaEntity media);
    }
}
