﻿using System;

namespace Iswenzz.AION.DBParser.Buttons
{
    public static class ButtonTable
    {
        public static Button[] Button = new Button[]
        {
            new Button("NPC")
        };

        public static ButtonNpc[] Npc = new ButtonNpc[]
        {
            new ButtonNpc("Elyos", "http://aiondatabase.net/en/npcs/light/", true),
            new ButtonNpc("Asmodian", "http://aiondatabase.net/en/npcs/dark/", true),
            new ButtonNpc("Shugo", "http://aiondatabase.net/en/npcs/shugo/", true),
            new ButtonNpc("Monsters", "http://aiondatabase.net/en/npcs/monsters/", true),
            new ButtonNpc("Named monsters", "http://aiondatabase.net/en/npcs/named/", true),
            new ButtonNpc("Grade"),
            new ButtonNpc("Zone")
        };

        public static ButtonNpcGrade[] Grade = new ButtonNpcGrade[]
        {
            new ButtonNpcGrade("Normal", "http://aiondatabase.net/en/npcs/normal/", true),
            new ButtonNpcGrade("Elite", "http://aiondatabase.net/en/npcs/elite/", true),
            new ButtonNpcGrade("Heroic", "http://aiondatabase.net/en/npcs/heroic/", true),
            new ButtonNpcGrade("Legendary", "http://aiondatabase.net/en/npcs/legendary/", true)
        };

        public static ButtonNpcZone[] Zone = new ButtonNpcZone[]
        {
            new ButtonNpcZone("PANDAEMONIUM", "http://aiondatabase.net/en/npcs/120010000/", true),
            new ButtonNpcZone("MARCHUTAN", "http://aiondatabase.net/en/npcs/120020000/", true),
            new ButtonNpcZone("MARCHUTAN_PRIORY", "http://aiondatabase.net/en/npcs/120080000/", true),
            new ButtonNpcZone("FATEBOUND_ABBEY", "http://aiondatabase.net/en/npcs/140010000/", true),
            new ButtonNpcZone("ISHALGEN", "http://aiondatabase.net/en/npcs/220010000/", true),
            new ButtonNpcZone("MORHEIM", "http://aiondatabase.net/en/npcs/220020000/", true),
            new ButtonNpcZone("ALTGARD", "http://aiondatabase.net/en/npcs/220030000/", true),
            new ButtonNpcZone("BELUSLAN", "http://aiondatabase.net/en/npcs/220040000/", true),
            new ButtonNpcZone("BRUSTHONIN", "http://aiondatabase.net/en/npcs/220050000/", true),
            new ButtonNpcZone("NOSRA", "http://aiondatabase.net/en/npcs/220110000/", true),
            new ButtonNpcZone("TOWER_OF_ETERNITY_D", "http://aiondatabase.net/en/npcs/220120000/", true),
            new ButtonNpcZone("PERNON", "http://aiondatabase.net/en/npcs/710010000/", true),
            new ButtonNpcZone("SANCTUM", "http://aiondatabase.net/en/npcs/110010000/", true),
            new ButtonNpcZone("KAISINEL", "http://aiondatabase.net/en/npcs/110020000/", true),
            new ButtonNpcZone("KAISINEL_ACADEMY", "http://aiondatabase.net/en/npcs/110070000/", true),
            new ButtonNpcZone("WISPLIGHT_ABBEY", "http://aiondatabase.net/en/npcs/130090000/", true),
            new ButtonNpcZone("POETA", "http://aiondatabase.net/en/npcs/210010000/", true),
            new ButtonNpcZone("ELTNEN", "http://aiondatabase.net/en/npcs/210020000/", true),
            new ButtonNpcZone("VERTERON", "http://aiondatabase.net/en/npcs/210030000/", true),
            new ButtonNpcZone("HEIRON", "http://aiondatabase.net/en/npcs/210040000/", true),
            new ButtonNpcZone("THEOBOMOS", "http://aiondatabase.net/en/npcs/210060000/", true),
            new ButtonNpcZone("ESTERRA", "http://aiondatabase.net/en/npcs/210100000/", true),
            new ButtonNpcZone("TOWER_OF_ETERNITY_L", "http://aiondatabase.net/en/npcs/210110000/", true),
            new ButtonNpcZone("LIVE_PARTY_CONCERT_HALL", "http://aiondatabase.net/en/npcs/600080000/", true),
            new ButtonNpcZone("ORIEL", "http://aiondatabase.net/en/npcs/700010000/", true),
            new ButtonNpcZone("INGGISON", "http://aiondatabase.net/en/npcs/210050000/", true),
            new ButtonNpcZone("LF4_M", "http://aiondatabase.net/en/npcs/210130000/", true),
            new ButtonNpcZone("SIGNIA", "http://aiondatabase.net/en/npcs/210070000/", true),
            new ButtonNpcZone("GRIFFOEN", "http://aiondatabase.net/en/npcs/210080000/", true),
            new ButtonNpcZone("IDIAN_DEPTHS_L", "http://aiondatabase.net/en/npcs/210090000/", true),
            new ButtonNpcZone("GELKMAROS", "http://aiondatabase.net/en/npcs/220070000/", true),
            new ButtonNpcZone("DF4_M", "http://aiondatabase.net/en/npcs/220140000/", true),
            new ButtonNpcZone("VENGAR", "http://aiondatabase.net/en/npcs/220080000/", true),
            new ButtonNpcZone("HABROK", "http://aiondatabase.net/en/npcs/220090000/", true),
            new ButtonNpcZone("IDIAN_DEPTHS_D", "http://aiondatabase.net/en/npcs/220100000/", true),
            new ButtonNpcZone("SILENTERA_CANYON", "http://aiondatabase.net/en/npcs/600010000/", true),
            new ButtonNpcZone("TIAMAT_DOWN", "http://aiondatabase.net/en/npcs/600040000/", true),
            new ButtonNpcZone("TIAMAT_DOWN_M", "http://aiondatabase.net/en/npcs/600041000/", true),
            new ButtonNpcZone("KALDOR", "http://aiondatabase.net/en/npcs/600090000/", true),
            new ButtonNpcZone("AKARON", "http://aiondatabase.net/en/npcs/600100000/", true),
            new ButtonNpcZone("TIAMARANTA_EYE", "http://aiondatabase.net/en/npcs/300400000/", true),
            new ButtonNpcZone("SARPAN", "http://aiondatabase.net/en/npcs/600020000/", true),
            new ButtonNpcZone("SARPAN_SKY", "http://aiondatabase.net/en/npcs/300410000/", true),
            new ButtonNpcZone("TIAMARANTA", "http://aiondatabase.net/en/npcs/600030000/", true),
            new ButtonNpcZone("UNDERPASS_M", "http://aiondatabase.net/en/npcs/600110000/", true),
            new ButtonNpcZone("NORHTERN_KATALAM", "http://aiondatabase.net/en/npcs/600050000/", true),
            new ButtonNpcZone("SOUTHERN_KATALAM", "http://aiondatabase.net/en/npcs/600060000/", true),
            new ButtonNpcZone("UNDERGROUND_KATALAM", "http://aiondatabase.net/en/npcs/600070000/", true),
            new ButtonNpcZone("RESHANTA", "http://aiondatabase.net/en/npcs/400010000/", true),
            new ButtonNpcZone("BELUS", "http://aiondatabase.net/en/npcs/400020000/", true),
            new ButtonNpcZone("TRANSIDIUM_ANNEX", "http://aiondatabase.net/en/npcs/400030000/", true),
            new ButtonNpcZone("ASPIDA", "http://aiondatabase.net/en/npcs/400040000/", true),
            new ButtonNpcZone("ATANATOS", "http://aiondatabase.net/en/npcs/400050000/", true),
            new ButtonNpcZone("DISILLON", "http://aiondatabase.net/en/npcs/400060000/", true),
            new ButtonNpcZone("DE_PRISON", "http://aiondatabase.net/en/npcs/510010000/", true),
            new ButtonNpcZone("DF_PRISON", "http://aiondatabase.net/en/npcs/520010000/", true),
            new ButtonNpcZone("ARENA_EVENT_L", "http://aiondatabase.net/en/npcs/210120000/", true),
            new ButtonNpcZone("ARENA_EVENT_D", "http://aiondatabase.net/en/npcs/220130000/", true),
            new ButtonNpcZone("IDABPRO", "http://aiondatabase.net/en/npcs/300010000/", true),
            new ButtonNpcZone("NOCHSANA_TRAINING_CAMP", "http://aiondatabase.net/en/npcs/300030000/", true),
            new ButtonNpcZone("PROTECTOR_REALM", "http://aiondatabase.net/en/npcs/300330000/", true),
            new ButtonNpcZone("DARK_POETA", "http://aiondatabase.net/en/npcs/300040000/", true),
            new ButtonNpcZone("ASTERIA_CHAMBER", "http://aiondatabase.net/en/npcs/300050000/", true),
            new ButtonNpcZone("SULFUR_TREE_NEST", "http://aiondatabase.net/en/npcs/300060000/", true),
            new ButtonNpcZone("CHAMBER_OF_ROAH", "http://aiondatabase.net/en/npcs/300070000/", true),
            new ButtonNpcZone("LEFT_WING_CHAMBER", "http://aiondatabase.net/en/npcs/300080000/", true),
            new ButtonNpcZone("RIGHT_WING_CHAMBER", "http://aiondatabase.net/en/npcs/300090000/", true),
            new ButtonNpcZone("STEEL_RAKE", "http://aiondatabase.net/en/npcs/300100000/", true),
            new ButtonNpcZone("DREDGION", "http://aiondatabase.net/en/npcs/300110000/", true),
            new ButtonNpcZone("KYSIS_CHAMBER", "http://aiondatabase.net/en/npcs/300120000/", true),
            new ButtonNpcZone("MIREN_CHAMBER", "http://aiondatabase.net/en/npcs/300130000/", true),
            new ButtonNpcZone("KROTAN_CHAMBER", "http://aiondatabase.net/en/npcs/300140000/", true),
            new ButtonNpcZone("UDAS_TEMPLE", "http://aiondatabase.net/en/npcs/300150000/", true),
            new ButtonNpcZone("UDAS_TEMPLE_LOWER", "http://aiondatabase.net/en/npcs/300160000/", true),
            new ButtonNpcZone("BESHMUNDIR_TEMPLE", "http://aiondatabase.net/en/npcs/300170000/", true),
            new ButtonNpcZone("TALOCS_HOLLOW", "http://aiondatabase.net/en/npcs/300190000/", true),
            new ButtonNpcZone("HARAMEL", "http://aiondatabase.net/en/npcs/300200000/", true),
            new ButtonNpcZone("MUADA_TRENCHER", "http://aiondatabase.net/en/npcs/300380000/", true),
            new ButtonNpcZone("DREDGION_OF_CHANTRA", "http://aiondatabase.net/en/npcs/300210000/", true),
            new ButtonNpcZone("ABYSSAL_SPLINTER", "http://aiondatabase.net/en/npcs/300220000/", true),
            new ButtonNpcZone("KROMEDE_TRIAL", "http://aiondatabase.net/en/npcs/300230000/", true),
            new ButtonNpcZone("ATURAM_SKY_FORTRESS", "http://aiondatabase.net/en/npcs/300240000/", true),
            new ButtonNpcZone("ATURAM_SKY_FORTRESS_BONUS", "http://aiondatabase.net/en/npcs/300241000/", true),
            new ButtonNpcZone("ESOTERRACE", "http://aiondatabase.net/en/npcs/300250000/", true),
            new ButtonNpcZone("RENTUS_BASE", "http://aiondatabase.net/en/npcs/300280000/", true),
            new ButtonNpcZone("EMPYREAN_CRUCIBLE", "http://aiondatabase.net/en/npcs/300300000/", true),
            new ButtonNpcZone("CRUCIBLE_CHALLENGE", "http://aiondatabase.net/en/npcs/300320000/", true),
            new ButtonNpcZone("ARENA_OF_CHAOS", "http://aiondatabase.net/en/npcs/300350000/", true),
            new ButtonNpcZone("ARENA_OF_DISCIPLINE", "http://aiondatabase.net/en/npcs/300360000/", true),
            new ButtonNpcZone("CHAOS_TRAINING_GROUNDS", "http://aiondatabase.net/en/npcs/300420000/", true),
            new ButtonNpcZone("DISCIPLINE_TRAINING_GROUNDS", "http://aiondatabase.net/en/npcs/300430000/", true),
            new ButtonNpcZone("TERATH_DREDGION", "http://aiondatabase.net/en/npcs/300440000/", true),
            new ButtonNpcZone("ARENA_OF_HARMONY", "http://aiondatabase.net/en/npcs/300450000/", true),
            new ButtonNpcZone("STEEL_RAKE_CABIN", "http://aiondatabase.net/en/npcs/300460000/", true),
            new ButtonNpcZone("SEALED_HALL_OF_KNOWLEDGE", "http://aiondatabase.net/en/npcs/300480000/", true),
            new ButtonNpcZone("TIAMAT_STRONGHOLD", "http://aiondatabase.net/en/npcs/300510000/", true),
            new ButtonNpcZone("DRAGON_LORD_REFUGE", "http://aiondatabase.net/en/npcs/300520000/", true),
            new ButtonNpcZone("ETERNAL_BASTION", "http://aiondatabase.net/en/npcs/300540000/", true),
            new ButtonNpcZone("VOID_CUBE", "http://aiondatabase.net/en/npcs/300580000/", true),
            new ButtonNpcZone("ARENA_OF_GLORY", "http://aiondatabase.net/en/npcs/300550000/", true),
            new ButtonNpcZone("SHUGO_IMPERIAL_TOMB", "http://aiondatabase.net/en/npcs/300560000/", true),
            new ButtonNpcZone("IDLDF5Re_02", "http://aiondatabase.net/en/npcs/300530000/", true),
            new ButtonNpcZone("HARMONY_TRAINING_GROUND", "http://aiondatabase.net/en/npcs/300570000/", true),
            new ButtonNpcZone("OPHIDAN_BRIDGE", "http://aiondatabase.net/en/npcs/300590000/", true),
            new ButtonNpcZone("UNSTABLE_ABYSSAL_SPLINTER", "http://aiondatabase.net/en/npcs/300600000/", true),
            new ButtonNpcZone("IDTiamat_Israphel", "http://aiondatabase.net/en/npcs/300500000/", true),
            new ButtonNpcZone("RAKSANG_RUINS", "http://aiondatabase.net/en/npcs/300610000/", true),
            new ButtonNpcZone("RAKSANG", "http://aiondatabase.net/en/npcs/300310000/", true),
            new ButtonNpcZone("IDTiamat_Solo", "http://aiondatabase.net/en/npcs/300490000/", true),
            new ButtonNpcZone("OCCUPIED_RENTUS_BASE", "http://aiondatabase.net/en/npcs/300620000/", true),
            new ButtonNpcZone("ANGUISHED_DRAGON_LORD_REFUGE", "http://aiondatabase.net/en/npcs/300630000/", true),
            new ButtonNpcZone("THE_HEXWAY", "http://aiondatabase.net/en/npcs/300700000/", true),
            new ButtonNpcZone("INFINITY_SHARD", "http://aiondatabase.net/en/npcs/300800000/", true),
            new ButtonNpcZone("UNITY_TRAINING_GROUNDS", "http://aiondatabase.net/en/npcs/301100000/", true),
            new ButtonNpcZone("IDRuneweapon_Q", "http://aiondatabase.net/en/npcs/300900000/", true),
            new ButtonNpcZone("RUNADIUM", "http://aiondatabase.net/en/npcs/301110000/", true),
            new ButtonNpcZone("IDLDF5RE_solo_Q", "http://aiondatabase.net/en/npcs/301000000/", true),
            new ButtonNpcZone("IDShulack_Rose_Solo_01", "http://aiondatabase.net/en/npcs/301010000/", true),
            new ButtonNpcZone("IDShulack_Rose_Solo_02", "http://aiondatabase.net/en/npcs/301020000/", true),
            new ButtonNpcZone("IDShulack_Rose_01", "http://aiondatabase.net/en/npcs/301030000/", true),
            new ButtonNpcZone("IDShulack_Rose_02", "http://aiondatabase.net/en/npcs/301040000/", true),
            new ButtonNpcZone("IDShulack_Rose_03", "http://aiondatabase.net/en/npcs/301050000/", true),
            new ButtonNpcZone("KAMARS_BATTLEFIELD", "http://aiondatabase.net/en/npcs/301120000/", true),
            new ButtonNpcZone("SAURO_SUPPLY_BASE", "http://aiondatabase.net/en/npcs/301130000/", true),
            new ButtonNpcZone("SEIZED_DANUAR_SANCTUARY", "http://aiondatabase.net/en/npcs/301140000/", true),
            new ButtonNpcZone("ASTERIA_IU_SOLO", "http://aiondatabase.net/en/npcs/301150000/", true),
            new ButtonNpcZone("NIGHTMARE_CIRCUS", "http://aiondatabase.net/en/npcs/301160000/", true),
            new ButtonNpcZone("RUKIBUKI_CIRCUS_TROUPE_CAMP", "http://aiondatabase.net/en/npcs/301200000/", true),
            new ButtonNpcZone("ENGULFED_OPHIDAN_BRIDGE", "http://aiondatabase.net/en/npcs/301210000/", true),
            new ButtonNpcZone("IRON_WALL_WARFRONT", "http://aiondatabase.net/en/npcs/301220000/", true),
            new ButtonNpcZone("ILLUMINARY_OBELISK", "http://aiondatabase.net/en/npcs/301230000/", true),
            new ButtonNpcZone("LEGION_KYSIS_BARRACKS", "http://aiondatabase.net/en/npcs/301240000/", true),
            new ButtonNpcZone("IDLDF5RE_02_L", "http://aiondatabase.net/en/npcs/301170000/", true),
            new ButtonNpcZone("IDLDF5RE_03_L", "http://aiondatabase.net/en/npcs/301180000/", true),
            new ButtonNpcZone("IDLDF5RE_Solo_L", "http://aiondatabase.net/en/npcs/301190000/", true),
            new ButtonNpcZone("LEGION_MIREN_BARRACKS", "http://aiondatabase.net/en/npcs/301250000/", true),
            new ButtonNpcZone("LEGION_KROTAN_BARRACKS", "http://aiondatabase.net/en/npcs/301260000/", true),
            new ButtonNpcZone("LINKGATE_FOUNDRY", "http://aiondatabase.net/en/npcs/301270000/", true),
            new ButtonNpcZone("KYSIS_BARRACKS", "http://aiondatabase.net/en/npcs/301280000/", true),
            new ButtonNpcZone("MIREN_BARRACKS", "http://aiondatabase.net/en/npcs/301290000/", true),
            new ButtonNpcZone("KROTAN_BARRACKS", "http://aiondatabase.net/en/npcs/301300000/", true),
            new ButtonNpcZone("IDGEL_DOME", "http://aiondatabase.net/en/npcs/301310000/", true),
            new ButtonNpcZone("LUCKY_OPHIDAN_BRIDGE", "http://aiondatabase.net/en/npcs/301320000/", true),
            new ButtonNpcZone("RUNADIUM_BONUS", "http://aiondatabase.net/en/npcs/301330000/", true),
            new ButtonNpcZone("LINKGATE_FOUNDRY_Q", "http://aiondatabase.net/en/npcs/301340000/", true),
            new ButtonNpcZone("RUNADIUM_HEROIC", "http://aiondatabase.net/en/npcs/301360000/", true),
            new ButtonNpcZone("INFERNAL_ILLUMINARY_OBELISK", "http://aiondatabase.net/en/npcs/301370000/", true),
            new ButtonNpcZone("DANUAR_SANCTUARY", "http://aiondatabase.net/en/npcs/301380000/", true),
            new ButtonNpcZone("DRAKENSPIRE_DEPTHS", "http://aiondatabase.net/en/npcs/301390000/", true),
            new ButtonNpcZone("THE_SHUGO_EMPEROR_VAULT", "http://aiondatabase.net/en/npcs/301400000/", true),
            new ButtonNpcZone("STONESPEAR_REACH", "http://aiondatabase.net/en/npcs/301500000/", true),
            new ButtonNpcZone("SEALED_ARGENT_MANOR", "http://aiondatabase.net/en/npcs/301510000/", true),
            new ButtonNpcZone("ARGENT_MANOR", "http://aiondatabase.net/en/npcs/300270000/", true),
            new ButtonNpcZone("DRAKENSPIRE_DEPTHS_Q", "http://aiondatabase.net/en/npcs/301520000/", true),
            new ButtonNpcZone("LIBRARY_OF_KNOWLEDGE", "http://aiondatabase.net/en/npcs/301540000/", true),
            new ButtonNpcZone("GARDEN_OF_KNOWLEDGE", "http://aiondatabase.net/en/npcs/301550000/", true),
            new ButtonNpcZone("MUSEUM_OF_KNOWLEDGE", "http://aiondatabase.net/en/npcs/301560000/", true),
            new ButtonNpcZone("LIBRARY_OF_KNOWLEDGE_QUEST", "http://aiondatabase.net/en/npcs/301570000/", true),
            new ButtonNpcZone("SANCTUARY_DUNGEON", "http://aiondatabase.net/en/npcs/301580000/", true),
            new ButtonNpcZone("SHUGO_EMPEROR_VAULT", "http://aiondatabase.net/en/npcs/301590000/", true),
            new ButtonNpcZone("ADMA_RUINS", "http://aiondatabase.net/en/npcs/301600000/", true),
            new ButtonNpcZone("ELEMENTAL_LORDS_LABORATORY", "http://aiondatabase.net/en/npcs/301610000/", true),
            new ButtonNpcZone("ELEMENTIS_FOREST", "http://aiondatabase.net/en/npcs/300260000/", true),
            new ButtonNpcZone("ARKHALS_HIDDEN_SPACE", "http://aiondatabase.net/en/npcs/301620000/", true),
            new ButtonNpcZone("HELL_PASS", "http://aiondatabase.net/en/npcs/301630000/", true),
            new ButtonNpcZone("IDEVENT_DEF", "http://aiondatabase.net/en/npcs/301631000/", true),
            new ButtonNpcZone("MECHANERKS_WEAPONS_FACTORY", "http://aiondatabase.net/en/npcs/301640000/", true),
            new ButtonNpcZone("ASHUNATAL_DREDGION", "http://aiondatabase.net/en/npcs/301650000/", true),
            new ButtonNpcZone("KROBAN_BASE", "http://aiondatabase.net/en/npcs/301660000/", true),
            new ButtonNpcZone("BALAUR_MARCHING_ROUTE", "http://aiondatabase.net/en/npcs/301670000/", true),
            new ButtonNpcZone("RUNATORIUM_RUINS", "http://aiondatabase.net/en/npcs/301680000/", true),
            new ButtonNpcZone("AETHER_MINE", "http://aiondatabase.net/en/npcs/301690000/", true),
            new ButtonNpcZone("TREASURE_ISLAND_OF_COURAGE", "http://aiondatabase.net/en/npcs/301700000/", true),
            new ButtonNpcZone("MIRASH_REFUGE", "http://aiondatabase.net/en/npcs/301720000/", true),
            new ButtonNpcZone("FIRE_TEMPLE_OF_MEMORY", "http://aiondatabase.net/en/npcs/302000000/", true),
            new ButtonNpcZone("RIFT_OF_OBLIVION", "http://aiondatabase.net/en/npcs/302100000/", true),
            new ButtonNpcZone("RIFT_OF_OBLIVION_BONUS", "http://aiondatabase.net/en/npcs/302100000/", true),
            new ButtonNpcZone("SANCTUM_BATTLEFIELD", "http://aiondatabase.net/en/npcs/302200000/", true),
            new ButtonNpcZone("PANDAEMONIUM_BATTLEFIELD", "http://aiondatabase.net/en/npcs/302300000/", true),
            new ButtonNpcZone("GOLD_ARENA", "http://aiondatabase.net/en/npcs/302310000/", true),
            new ButtonNpcZone("GOLDEN_CRUCIBLE", "http://aiondatabase.net/en/npcs/302320000/", true),
            new ButtonNpcZone("KUMUKI_HIDEOUT", "http://aiondatabase.net/en/npcs/302330000/", true),
            new ButtonNpcZone("SATRA_TREASURE_HOARD", "http://aiondatabase.net/en/npcs/300470000/", true),
            new ButtonNpcZone("NARAKKALLI", "http://aiondatabase.net/en/npcs/302340000/", true),
            new ButtonNpcZone("NEVIWIND_CANYON", "http://aiondatabase.net/en/npcs/302350000/", true),
            new ButtonNpcZone("GOLD_ARENA_LONE_FIGHTER", "http://aiondatabase.net/en/npcs/302360000/", true),
            new ButtonNpcZone("GOLDEN_CRUCIBLE_GROUP_BATTLE", "http://aiondatabase.net/en/npcs/302370000/", true),
            new ButtonNpcZone("GOLD_ARENA_GROUP_BATTLES_L", "http://aiondatabase.net/en/npcs/302380000/", true),
            new ButtonNpcZone("GOLDEN_CRUCIBLE_GROUP_BATTLES_L", "http://aiondatabase.net/en/npcs/302390000/", true),
            new ButtonNpcZone("TOWER_OF_CHALLENGE", "http://aiondatabase.net/en/npcs/302400000/", true),
            new ButtonNpcZone("GOLD_ARENA_GROUP_BATTLES_D", "http://aiondatabase.net/en/npcs/302410000/", true),
            new ButtonNpcZone("GOLDEN_CRUCIBLE_GROUP_BATTLES_D", "http://aiondatabase.net/en/npcs/302420000/", true),
            new ButtonNpcZone("KARAMATIS_A", "http://aiondatabase.net/en/npcs/310010000/", true),
            new ButtonNpcZone("KARAMATIS_B", "http://aiondatabase.net/en/npcs/310020000/", true),
            new ButtonNpcZone("AERDINA", "http://aiondatabase.net/en/npcs/310030000/", true),
            new ButtonNpcZone("GERANAIA", "http://aiondatabase.net/en/npcs/310040000/", true),
            new ButtonNpcZone("AETHEROGENETICS_LAB", "http://aiondatabase.net/en/npcs/310050000/", true),
            new ButtonNpcZone("FRAGMENT_OF_DARKNESS", "http://aiondatabase.net/en/npcs/310060000/", true),
            new ButtonNpcZone("SLIVER_OF_DARKNESS", "http://aiondatabase.net/en/npcs/310070000/", true),
            new ButtonNpcZone("SANCTUM_UNDERGROUND_ARENA", "http://aiondatabase.net/en/npcs/310080000/", true),
            new ButtonNpcZone("INDRATU_FORTRESS", "http://aiondatabase.net/en/npcs/310090000/", true),
            new ButtonNpcZone("AZOTURAN_FORTRESS", "http://aiondatabase.net/en/npcs/310100000/", true),
            new ButtonNpcZone("THEOBOMOS_LAB", "http://aiondatabase.net/en/npcs/310110000/", true),
            new ButtonNpcZone("ATAXIAR_A", "http://aiondatabase.net/en/npcs/310120000/", true),
            new ButtonNpcZone("ATAXIAR_B", "http://aiondatabase.net/en/npcs/320010000/", true),
            new ButtonNpcZone("ATAXIAR_C", "http://aiondatabase.net/en/npcs/320020000/", true),
            new ButtonNpcZone("BREGIRUN", "http://aiondatabase.net/en/npcs/320030000/", true),
            new ButtonNpcZone("NIDALBER", "http://aiondatabase.net/en/npcs/320040000/", true),
            new ButtonNpcZone("ARKANIS_TEMPLE", "http://aiondatabase.net/en/npcs/320050000/", true),
            new ButtonNpcZone("SPACE_OF_OBLIVION", "http://aiondatabase.net/en/npcs/320060000/", true),
            new ButtonNpcZone("SPACE_OF_DESTINY", "http://aiondatabase.net/en/npcs/320070000/", true),
            new ButtonNpcZone("DRAUPNIR_CAVE", "http://aiondatabase.net/en/npcs/320080000/", true),
            new ButtonNpcZone("TRINIEL_UNDERGROUND_ARENA", "http://aiondatabase.net/en/npcs/320090000/", true),
            new ButtonNpcZone("FIRE_TEMPLE", "http://aiondatabase.net/en/npcs/320100000/", true),
            new ButtonNpcZone("ALQUIMIA_RESEARCH_CENTER", "http://aiondatabase.net/en/npcs/320110000/", true),
            new ButtonNpcZone("SHADOW_COURT_DUNGEON", "http://aiondatabase.net/en/npcs/320120000/", true),
            new ButtonNpcZone("ADMA_STRONGHOLD", "http://aiondatabase.net/en/npcs/320130000/", true),
            new ButtonNpcZone("ATAXIAR_D", "http://aiondatabase.net/en/npcs/320140000/", true),
            new ButtonNpcZone("PADMARASHKA_CAVE", "http://aiondatabase.net/en/npcs/320150000/", true),
            new ButtonNpcZone("HOLY_TOWER_L", "http://aiondatabase.net/en/npcs/310160000/", true),
            new ButtonNpcZone("HOLY_TOWER_D", "http://aiondatabase.net/en/npcs/320160000/", true),
            new ButtonNpcZone("HOUSING_LC_LEGION", "http://aiondatabase.net/en/npcs/700020000/", true),
            new ButtonNpcZone("HOUSING_DC_LEGION", "http://aiondatabase.net/en/npcs/710020000/", true),
            new ButtonNpcZone("ORIEL_STUDIO", "http://aiondatabase.net/en/npcs/720010000/", true),
            new ButtonNpcZone("PERNON_STUDIO", "http://aiondatabase.net/en/npcs/730010000/", true)
        };
    }
}
