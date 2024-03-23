namespace DarkwoodEditor
{
    //
    // Root
    //
    public class Root
    {
        public int majorVersion { get; set; }
        public int minorVersion { get; set; }
        public int majorVersionCompatibility { get; set; }
        public int minorVersionCompatibility { get; set; }
        public int RCVersion { get; set; }
        public int RCVersionCompatibility { get; set; }
        public SaveMS saveMS { get; set; }
        public PS pS { get; set; }
        public IS iS { get; set; }
        public HS hS { get; set; }
        public CnS cnS { get; set; }
        public DrS drS { get; set; }
        public OutS outS { get; set; }
        public RaS raS { get; set; }
        public FlaS flaS { get; set; }
        public JoS joS { get; set; }
        public NumS numS { get; set; }
        public EvS evS { get; set; }
        public ChspS chspS { get; set; }
        public WorldGenS worldGenS { get; set; }
        public GridS gridS { get; set; }
        public BbdS bbdS { get; set; }
        public MapS mapS { get; set; }
        public NightScenS nightScenS { get; set; }
        public ChDC chDC { get; set; }
        public List<SavedObj> savedObjs { get; set; }
    }

    public class SaveMS
    {
        public int currentUniqueID { get; set; }
    }

    //
    // Player
    //
    public class DrS
    {
        public List<string> presetList { get; set; }
        public bool hadDreamAtLvl2 { get; set; }
        public bool hadDreamAtLvl3 { get; set; }
        public bool hadDreamAtLvl5 { get; set; }
        public bool hadDreamAtLvl6 { get; set; }
        public bool hadDreamAtLvl7 { get; set; }
        public bool wantToDream { get; set; }
        public object dreamName { get; set; }
        public double timeCopy { get; set; }
        public int placeStartedDreamingID { get; set; }
        public EffectsCopy effectsCopy { get; set; }
        public List<object> inventorySlotsCopy { get; set; }
        public List<object> hotbarSlotsCopy { get; set; }
        public List<double> positionCopy { get; set; }
    }

    public class PS
    {
        public List<double> pos { get; set; }
        public List<double> rot { get; set; }
        public double health { get; set; }
        public double stamina { get; set; }
        public int experience { get; set; }
        public int currentLevel { get; set; }
        public int healthUpgrades { get; set; }
        public int staminaUpgrades { get; set; }
        public int hotbarUpgrades { get; set; }
        public int inventoryUpgrades { get; set; }
        public int lastTimeAte { get; set; }
        public double saturation { get; set; }
        public bool fedToday { get; set; }
        public int lifes { get; set; }
        public List<object> recipes { get; set; }
        public List<object> craftedItems { get; set; }
        public ChEffS chEffS { get; set; }
        public SkillS skillS { get; set; }
        public int expMachineId { get; set; }
        public bool examinedExpMachine { get; set; }
        public bool gotHitAtLeastOnce { get; set; }
        public bool diedAtLeastOnce { get; set; }
    }

    public class JoS
    {
        public List<object> keysList { get; set; }
        public List<object> notesList { get; set; }
        public List<object> itemsList { get; set; }
        public List<LocationsList> locationsList { get; set; }
        public List<object> entriesList { get; set; }
        public List<object> locationDirections { get; set; }
    }

    public class SkillS
    {
        public List<object> availableSkillsStates { get; set; }
        public List<object> skillsStates { get; set; }
        public bool canActivateSkill { get; set; }
    }

    public class SpecialAttack
    {
        public string type { get; set; }
        public bool canUse { get; set; }
    }

    public class EffectsCopy
    {
        public List<object> effects { get; set; }
    }

    public class ChEffS
    {
        public List<object> effects { get; set; }
    }

    //
    // Events and NPCs
    //
    public class CharacterState
    {
        public int type { get; set; }
        public int timesKilled { get; set; }
        public int difficulty { get; set; }
        public int minNightDifficulty { get; set; }
        public int minDreamDifficulty { get; set; }
        public List<SpecialAttack> specialAttacks { get; set; }
    }

    public class ChDC
    {
        public List<CharacterState> characterStates { get; set; }
    }

    public class ChspS
    {
        public List<object> spawnedCharacterIDs { get; set; }
        public List<object> nocturnalCharsIDs { get; set; }
        public int holderID { get; set; }
        public int charactersEscapedFromLocationHolderID { get; set; }
    }

    public class Dialogue
    {
        public string name { get; set; }
        public bool alreadyShown { get; set; }
        public bool disabled { get; set; }
    }

    public class DialogueState
    {
        public string name { get; set; }
        public List<Dialogue> dialogues { get; set; }
        public List<object> specialOptions { get; set; }
        public int portraitType { get; set; }
    }

    public class Event
    {
        public bool disabled { get; set; }
        public int type { get; set; }
        public bool multipleTimesPerDay { get; set; }
        public int timeToStart { get; set; }
        public int startTimeMin { get; set; }
        public int startTimeMax { get; set; }
        public bool anyDay { get; set; }
        public int dayToStart { get; set; }
        public bool startedToday { get; set; }
        public bool randomizeOnNewDay { get; set; }
        public bool removeOnFire { get; set; }
        public double chance { get; set; }
        public string Value { get; set; }
    }

    public class EvS
    {
        public List<Event> events { get; set; }
        public List<object> activeEventCategories { get; set; }
        public List<int> worldEventsIds { get; set; }
        public List<object> gameEventsToFireAfterLoad { get; set; }
    }

    public class Flag
    {
        public string name { get; set; }
        public bool isTrue { get; set; }
        public int amount { get; set; }
        public bool ch2relevant { get; set; }
        public bool epilogueOutcomeRelevant { get; set; }
    }

    public class FlaS
    {
        public int karmaPoints { get; set; }
        public List<Flag> flags { get; set; }
        public List<NpcState> npcStates { get; set; }
        public List<DialogueState> dialogueStates { get; set; }
        public List<object> achievements { get; set; }
    }

    public class NightScenS
    {
        public int scenarioID { get; set; }
        public string previousScenarioName { get; set; }
        public int previousScenarioDifficulty { get; set; }
    }

    public class HS
    {
        public int slotCount { get; set; }
        public List<object> invItems { get; set; }
    }

    public class IS
    {
        public int slotCount { get; set; }
        public List<object> invItems { get; set; }
    }

    public class NpcState
    {
        public string name { get; set; }
        public int reputation { get; set; }
        public bool dead { get; set; }
        public int deadID { get; set; }
        public int attackedID { get; set; }
        public bool wantsToTalk { get; set; }
    }

    //
    // World
    //
    public class BbdS
    {
        public List<BigBiomeState> bigBiomeStates { get; set; }
    }

    public class BigBiomeState
    {
        public int type { get; set; }
        public List<object> globalCharactersIDs { get; set; }
    }

    public class ChunkState
    {
        public List<int> freeRoamingCharsIDs { get; set; }
        public List<object> nightSpawnedObjectsIDs { get; set; }
        public List<object> randomObjectsIDs { get; set; }
        public string biomeName { get; set; }
        public List<double> colliderSize { get; set; }
        public bool isBorderChunk { get; set; }
        public bool hasHideout { get; set; }
        public int locationId { get; set; }
        public int CharactersFreeRoamingId { get; set; }
    }

    public class GridS
    {
        public List<GridState> gridStates { get; set; }
    }

    public class GridState
    {
        public List<double> position { get; set; }
        public double xSize { get; set; }
        public double ySize { get; set; }
        public List<object> gNodesStates { get; set; }
        public List<object> cullables { get; set; }
        public object name { get; set; }
        public int type { get; set; }
    }

    public class Number
    {
        public string id { get; set; }
        public int digits { get; set; }
        public int number { get; set; }
    }

    public class NumS
    {
        public List<Number> numbers { get; set; }
        public List<YPositionOffset> yPositionOffsets { get; set; }
    }

    public class OutS
    {
        public List<object> spawnedLocationsKeys { get; set; }
        public List<object> spawnedLocationsValuesIDs { get; set; }
        public List<double> positionCopy { get; set; }
        public int timeCopy { get; set; }
        public bool playerInOutsideLocation { get; set; }
        public string currentLocationName { get; set; }
        public int actualSpawnedLocationsCount { get; set; }
        public int objectThatTransportedMeID { get; set; }
    }

    public class LocationsList
    {
        public string type { get; set; }
        public bool inDream { get; set; }
    }

    public class MapElS
    {
        public bool isOnMap { get; set; }
        public bool dontInitialize { get; set; }
        public string elementName { get; set; }
        public double rotation { get; set; }
        public double yOffset { get; set; }
        public bool selectable { get; set; }
        public string nameOverride { get; set; }
        public string spriteOverride { get; set; }
    }

    public class MapS
    {
        public object elementIDs { get; set; }
        public List<Type> types { get; set; }
    }

    public class SavedObj
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int pID { get; set; }
        public bool Active { get; set; }
        public List<double> p { get; set; }
        public List<double> r { get; set; }
        public List<double> s { get; set; }
        public MapElS mapElS { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
        public List<object> elementIDs { get; set; }
        public double scale { get; set; }
        public List<double> iconOffset { get; set; }
    }

    public class WorldGenS
    {
        public List<int> worldChunksIDs { get; set; }
        public List<int> locationsIDs { get; set; }
        public List<object> respawnPointsIDs { get; set; }
        public List<ChunkState> chunkStates { get; set; }
        public int playerBaseID { get; set; }
        public int outsideLocationsGOID { get; set; }
        public int roadsGOID { get; set; }
        public int majorVersion { get; set; }
        public int minorVersion { get; set; }
        public int chapterID { get; set; }
    }

    public class YPositionOffset
    {
        public int Item1 { get; set; }
        public int Item2 { get; set; }
    }

    //
    // Time and Weather
    //
    public class CnS
    {
        public int currentTime { get; set; }
        public int day { get; set; }
        public double gameTime { get; set; }
        public int workbenchLevel { get; set; }
        public bool isAfterDeath { get; set; }
        public bool gaveAfterNightRewards { get; set; }
    }

    public class RaS
    {
        public bool raining { get; set; }
        public bool rainToday { get; set; }
        public double timeToStart { get; set; }
        public double lightningTime { get; set; }
        public bool preRainLightning { get; set; }
        public double preRainLightningTime { get; set; }
        public double duration { get; set; }
        public TimeToFadeInFog timeToFadeInFog { get; set; }
        public TimeToFadeOutFog timeToFadeOutFog { get; set; }
        public bool fogFadedOutToday { get; set; }
        public bool fogIsActive { get; set; }
    }

    public class TimeToFadeInFog
    {
        public int day { get; set; }
        public int time { get; set; }
        public int equals { get; set; }
    }

    public class TimeToFadeOutFog
    {
        public int day { get; set; }
        public int time { get; set; }
        public int equals { get; set; }
    }
}
