﻿namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class WorldObject
    {
        private const int IdLength = 128;
        private const string IdChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "abcdefghijklmnopqrstuvwxyz" + "0123456789_";
        private static readonly Random random = new Random();
        private static readonly HashSet<string> allObjectIds = new HashSet<string>();

        protected WorldObject(string name = "")
        {
            this.Name = name;
            this.Id = WorldObject.GenerateObjectId();
        }

        public string Name { get; protected set; }

        public string Id { get; private set; }

        public static string GenerateObjectId()
        {
            StringBuilder resultBuilder = new StringBuilder();
            string result;

            do
            {
                for (int i = 0; i < WorldObject.IdLength; i++)
                {
                    resultBuilder.Append(IdChars[random.Next(0, WorldObject.IdChars.Length)]);
                }

                result = resultBuilder.ToString();
            }
            while (allObjectIds.Contains(result));

            return result;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Id.Equals((obj as WorldObject).Id);
        }
    }
}
