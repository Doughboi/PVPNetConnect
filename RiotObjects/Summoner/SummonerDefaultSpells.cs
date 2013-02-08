﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Summoner
{
    public class SummonerDefaultSpells : RiotGamesObject
    {
        #region Constructors and Callbacks

        public SummonerDefaultSpells(Callback callback)
        {
            this.callback = callback;
        }

        public SummonerDefaultSpells(TypedObject result)
        {
            base.SetFields<SummonerDefaultSpells>(this, result);
        }

        public delegate void Callback(SummonerDefaultSpells result);
        private Callback callback;
        public override void DoCallback(TypedObject result)
        {
            base.SetFields <SummonerDefaultSpells>(this, result);
            callback(this);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// Dictionary object for default spells based on game mode (Game modes: CLASSIC, ARAM, ODIN, TUTORIAL).
        /// </summary>
        [InternalName("summonerDefaultSpellMap")]
        public Dictionary<string, SummonerGameModeSpells> SummonerDefaultSpellMap { get; set; }

        /// <summary>
        /// Summoner ID number.
        /// </summary>
        [InternalName("summonerId")]
        public int summonerId { get; set; }

        #endregion
    }
}