using DarkwoodEditorWPF.Models;
using DarkwoodEditorWPF.ViewModels;
using DarkwoodEditorWPF.ViewModels.Ps;
using System.Windows.Media.Effects;

namespace DarkwoodEditorWPF.Helpers
{
	public class Data
	{
		//
		// Add data to ViewModels
		//
		// TODO: Refactor AddData and SaveData methods to use ConvertCollection methods
		public MainViewModel LoadData(string filePath, Root root)
		{
			ConvertCollections convert = new ConvertCollections();

			RootViewModel rootVM = new RootViewModel
			{
				MajorVersion = root.majorVersion,
				MinorVersion = root.minorVersion,
				MajorVersionCompatibility = root.majorVersionCompatibility,
				MinorVersionCompatibility = root.minorVersionCompatibility,
				RCVersion = root.RCVersion,
				RCVersionCompatibility = root.RCVersionCompatibility
			};

			ChEffS chEffS = root.pS?.chEffS ?? throw new NullReferenceException();
			ChEffsViewModel chEffsVM = new ChEffsViewModel
			{
				Effects = convert.ConvertEffectListToObservableCollection(chEffS.effects ?? throw new NullReferenceException())
			};

			SkillS skillS = root.pS?.skillS ?? throw new NullReferenceException();
			SkillsViewModel skillsVM = new SkillsViewModel
			{
				// Null for now due to lack of data in the sav.dat file
                AvailableSkillsStates = null, // convert.ConvertAvailableSkillStatesListToObservableCollection(skillS.availableSkillsStates ?? throw new NullReferenceException()),
				SkillsStates = convert.ConvertSkillsStatesListToObservableCollection(skillS.skillsStates ?? throw new NullReferenceException()),
				CanActivateSkill = skillS.canActivateSkill
			};

			PS ps = root.pS ?? throw new NullReferenceException();
			PsViewModel psVM = new PsViewModel
			{
				Health = ps.health,
				Stamina = ps.stamina,
				Experience = ps.experience,
				CurrentLevel = ps.currentLevel,
				HealthUpgrades = ps.healthUpgrades,
				StaminaUpgrades = ps.staminaUpgrades,
				HotbarUpgrades = ps.hotbarUpgrades,
				InventoryUpgrades = ps.inventoryUpgrades,
				LastTimeAte = ps.lastTimeAte,
				Saturation = ps.saturation,
				FedToday = ps.fedToday,
				Lifes = ps.lifes,
				Recipes = convert.ConvertStringListToObservableCollection(ps.recipes),
				CraftedItems = convert.ConvertCraftedItemListToObservableCollection(ps.craftedItems ?? throw new NullReferenceException()),
				ChEffS = chEffsVM,
                SkillS = skillsVM,
                GotHitAtLeastOnce = ps.gotHitAtLeastOnce,
				DiedAtLeastOnce = ps.diedAtLeastOnce
			};

			IS iS = root.iS ?? throw new NullReferenceException();
			IsViewModel isViewModel = new IsViewModel
			{
				SlotCount = iS.slotCount,
				InvItems = iS.invItems
			};

			HS hs = root.hS ?? throw new NullReferenceException();
			HsViewModel hsViewModel = new HsViewModel
			{
				SlotCount = hs.slotCount,
				InvItems = hs.invItems
			};

			CnS cnS = root.cnS ?? throw new NullReferenceException();
			CnSViewModel cnSViewModel = new CnSViewModel
			{
				CurrentTime = cnS.currentTime,
				Day = cnS.day,
				GameTime = cnS.gameTime,
				WorkbenchLevel = cnS.workbenchLevel,
				IsAfterDeath = cnS.isAfterDeath,
				GaveAfterNightRewards = cnS.gaveAfterNightRewards
			};

			EffectsCopy effectsCopy = root.drS?.effectsCopy ?? throw new NullReferenceException();
			EffectsCopyViewModel effectsCopyVM = new EffectsCopyViewModel
			{
                Effects = convert.ConvertEffectListToObservableCollection(effectsCopy.effects ?? throw new NullReferenceException())
            };

			DrS drS = root.drS ?? throw new NullReferenceException();
			DrSViewModel drSViewModel = new DrSViewModel
			{
				PresetList = convert.ConvertStringListToObservableCollection(drS.presetList ?? throw new NullReferenceException()),
				HadDreamAtLvl2 = drS.hadDreamAtLvl2,
				HadDreamAtLvl3 = drS.hadDreamAtLvl3,
				HadDreamAtLvl5 = drS.hadDreamAtLvl5,
				HadDreamAtLvl6 = drS.hadDreamAtLvl6,
				HadDreamAtLvl7 = drS.hadDreamAtLvl7,
				WantToDream = drS.wantToDream,
				DreamName = drS.dreamName,
				TimeCopy = drS.timeCopy,
				PlaceStartedDreamingID = drS.placeStartedDreamingID,
				EffectsCopy = effectsCopyVM,
				InventorySlotsCopy = drS.inventorySlotsCopy,
				HotbarSlotsCopy = drS.hotbarSlotsCopy,
				PositionCopy = drS.positionCopy
			};

			OutS outS = root.outS ?? throw new NullReferenceException();
			OutSViewModel outSViewModel = new OutSViewModel
			{
				SpawnedLocationsKeys = outS.spawnedLocationsKeys,
				SpawnedLocationsValuesIDs = outS.spawnedLocationsValuesIDs,
				PositionCopy = outS.positionCopy,
				TimeCopy = outS.timeCopy,
				PlayerInOutsideLocation = outS.playerInOutsideLocation,
				CurrentLocationName = outS.currentLocationName,
				ActualSpawnedLocationsCount = outS.actualSpawnedLocationsCount,
				ObjectThatTransportedMeID = outS.objectThatTransportedMeID
			};

			RaS raS = root.raS ?? throw new NullReferenceException();
			RaSViewModel raSViewModel = new RaSViewModel
			{
				Raining = raS.raining,
				RainToday = raS.rainToday,
				TimeToStart = raS.timeToStart,
				LightningTime = raS.lightningTime,
				PreRainLightning = raS.preRainLightning,
				PreRainLightningTime = raS.preRainLightningTime,
				Duration = raS.duration,
				TimeToFadeInFog = raS.timeToFadeInFog,
				TimeToFadeOutFog = raS.timeToFadeOutFog,
				FogFadedOutToday = raS.fogFadedOutToday,
				FogIsActive = raS.fogIsActive
			};

			FlaS flaS = root.flaS ?? throw new NullReferenceException();
			FlaSViewModel flaSViewModel = new FlaSViewModel
			{
				KarmaPoints = flaS.karmaPoints,
				Flags = flaS.flags,
				NpcStates = flaS.npcStates,
				DialogueStates = flaS.dialogueStates,
				Achievements = flaS.achievements
			};

			JoS joS = root.joS ?? throw new NullReferenceException();
			JoSViewModel joSViewModel = new JoSViewModel
			{
				KeysList = joS.keysList,
				NotesList = joS.notesList,
				ItemsList = joS.itemsList,
				LocationsList = joS.locationsList,
				EntriesList = joS.entriesList,
				LocationDirections = joS.locationDirections
			};

			NumS numS = root.numS ?? throw new NullReferenceException();
			NumSViewModel numSViewModel = new NumSViewModel
			{
				Numbers = numS.numbers,
				YPositionOffsets = numS.yPositionOffsets
			};

			EvS evS = root.evS ?? throw new NullReferenceException();
			EvSViewModel evSViewModel = new EvSViewModel
			{
				Events = evS.events,
				ActiveEventCategories = evS.activeEventCategories,
				WorldEventsIds = evS.worldEventsIds,
				GameEventsToFireAfterLoad = evS.gameEventsToFireAfterLoad
			};

			ChspS chspS = root.chspS ?? throw new NullReferenceException();
			ChspSViewModel chspSViewModel = new ChspSViewModel
			{
				SpawnedCharacterIDs = chspS.spawnedCharacterIDs,
				NocturnalCharsIDs = chspS.nocturnalCharsIDs,
				HolderID = chspS.holderID,
				CharactersEscapedFromLocationHolderID = chspS.charactersEscapedFromLocationHolderID
			};

			WorldGenS worldGenS = root.worldGenS ?? throw new NullReferenceException();
			WorldGenSViewModel worldGenSViewModel = new WorldGenSViewModel
			{
				WorldChunksIDs = worldGenS.worldChunksIDs,
				LocationsIDs = worldGenS.locationsIDs,
				RespawnPointsIDs = worldGenS.respawnPointsIDs,
				ChunkStates = worldGenS.chunkStates,
				PlayerBaseID = worldGenS.playerBaseID,
				OutsideLocationsGOID = worldGenS.outsideLocationsGOID,
				RoadsGOID = worldGenS.roadsGOID,
				MajorVersion = worldGenS.majorVersion,
				MinorVersion = worldGenS.minorVersion,
				ChapterID = worldGenS.chapterID
			};

			GridS gridS = root.gridS ?? throw new NullReferenceException();
			GridSViewModel gridSViewModel = new GridSViewModel
			{
				GridStates = gridS.gridStates
			};

			BbdS bbdS = root.bbdS ?? throw new NullReferenceException();
			BbdSViewModel bbdSViewModel = new BbdSViewModel
			{
				BigBiomeStates = bbdS.bigBiomeStates
			};

			MapS mapS = root.mapS ?? throw new NullReferenceException();
			MapSViewModel mapSViewModel = new MapSViewModel
			{
				ElementIDs = mapS.elementIDs,
				Types = mapS.types
			};

			NightScenS nightScenS = root.nightScenS ?? throw new NullReferenceException();
			NightScenSViewModel nightScenSViewModel = new NightScenSViewModel
			{
				ScenarioID = nightScenS.scenarioID,
				PreviousScenarioName = nightScenS.previousScenarioName,
				PreviousScenarioDifficulty = nightScenS.previousScenarioDifficulty
			};

			ChDC chDC = root.chDC ?? throw new NullReferenceException();
			ChDCViewModel chDCViewModel = new ChDCViewModel
			{
				CharacterStates = chDC.characterStates
			};

			List<SavedObj> savedObjs = root.savedObjs ?? throw new NullReferenceException();

			MainViewModel mainViewModel = new MainViewModel
			{
				FilePath = filePath,
				RootViewModel = rootVM,
				SaveMS = root.saveMS,
				PsViewModel = psVM,
				IsViewModel = isViewModel,
				HsViewModel = hsViewModel,
				CnsViewModel = cnSViewModel,
				DrSViewModel = drSViewModel,
				OutSViewModel = outSViewModel,
				RaSViewModel = raSViewModel,
				FlaSViewModel = flaSViewModel,
				JoSViewModel = joSViewModel,
				NumSViewModel = numSViewModel,
				EvSViewModel = evSViewModel,
				ChspSViewModel = chspSViewModel,
				WorldGenSViewModel = worldGenSViewModel,
				GridSViewModel = gridSViewModel,
				BbdSViewModel = bbdSViewModel,
				MapSViewModel = mapSViewModel,
				NightScenSViewModel = nightScenSViewModel,
				ChDCViewModel = chDCViewModel,
				SavedObjs = savedObjs
			};

			return mainViewModel;
		}

		// 
		// Save data from ViewModels to Root object
		//
		public Root SaveData(MainViewModel mainViewModel)
		{
			ConvertCollections convert = new ConvertCollections();

			SaveMS saveMS = mainViewModel.SaveMS ?? throw new NullReferenceException();

			ChEffsViewModel chEffsViewModel = mainViewModel.PsViewModel?.ChEffS ?? throw new NullReferenceException();
			ChEffS chEffS = new ChEffS
			{
				effects = convert.ConvertObservableCollectionToEffectList(chEffsViewModel.Effects ?? throw new NullReferenceException())
			};

			SkillsViewModel skillsViewModel = mainViewModel.PsViewModel?.SkillS ?? throw new NullReferenceException();
			SkillS skillS = new SkillS
			{
				// Null for now due to lack of data in the sav.dat file
                availableSkillsStates = null, // convert.ConvertObservableCollectionToAvailableSkillStatesList(skillsViewModel.AvailableSkillsStates ?? throw new NullReferenceException()),
                skillsStates = convert.ConvertObservableCollectionToSkillsStatesList(skillsViewModel.SkillsStates ?? throw new NullReferenceException()),
                canActivateSkill = skillsViewModel.CanActivateSkill
            };

			PsViewModel psViewModel = mainViewModel.PsViewModel ?? throw new NullReferenceException();
			PS ps = new PS
			{
				pos = psViewModel.Position,
				rot = psViewModel.Rotation,
				health = psViewModel.Health,
				stamina = psViewModel.Stamina,
				experience = psViewModel.Experience,
				currentLevel = psViewModel.CurrentLevel,
				healthUpgrades = psViewModel.HealthUpgrades,
				staminaUpgrades = psViewModel.StaminaUpgrades,
				hotbarUpgrades = psViewModel.HotbarUpgrades,
				inventoryUpgrades = psViewModel.InventoryUpgrades,
				lastTimeAte = psViewModel.LastTimeAte,
				saturation = psViewModel.Saturation,
				fedToday = psViewModel.FedToday,
				lifes = psViewModel.Lifes,
				recipes = convert.ConvertObservableCollectionToStringList(psViewModel.Recipes),
				craftedItems = convert.ConvertObservableCollectionToCraftedItemList(psViewModel.CraftedItems),
				chEffS = chEffS,
				skillS = skillS,
				expMachineId = psViewModel.ExpMachineId,
				examinedExpMachine = psViewModel.ExaminedExpMachine,
				gotHitAtLeastOnce = psViewModel.GotHitAtLeastOnce,
				diedAtLeastOnce = psViewModel.DiedAtLeastOnce
			};

			IsViewModel isViewModel = mainViewModel.IsViewModel ?? throw new NullReferenceException();
			IS iS = new IS
			{
				slotCount = isViewModel.SlotCount,
				invItems = isViewModel.InvItems
			};

			HsViewModel hsViewModel = mainViewModel.HsViewModel ?? throw new NullReferenceException();
			HS hS = new HS
			{
				slotCount = hsViewModel.SlotCount,
				invItems = hsViewModel.InvItems
			};

			CnSViewModel cnSViewModel = mainViewModel.CnsViewModel ?? throw new NullReferenceException();
			CnS cnS = new CnS
			{
				currentTime = cnSViewModel.CurrentTime,
				day = cnSViewModel.Day,
				gameTime = cnSViewModel.GameTime,
				workbenchLevel = cnSViewModel.WorkbenchLevel,
				isAfterDeath = cnSViewModel.IsAfterDeath,
				gaveAfterNightRewards = cnSViewModel.GaveAfterNightRewards
			};

			EffectsCopyViewModel effectsCopyViewModel = mainViewModel.DrSViewModel?.EffectsCopy ?? throw new NullReferenceException();
			EffectsCopy effectsCopy = new EffectsCopy
			{
                effects = convert.ConvertObservableCollectionToEffectList(effectsCopyViewModel.Effects ?? throw new NullReferenceException())
            };

			DrSViewModel drSViewModel = mainViewModel.DrSViewModel ?? throw new NullReferenceException();
			DrS drS = new DrS
			{
				presetList = convert.ConvertObservableCollectionToStringList(drSViewModel.PresetList ?? throw new NullReferenceException()),
				hadDreamAtLvl2 = drSViewModel.HadDreamAtLvl2,
				hadDreamAtLvl3 = drSViewModel.HadDreamAtLvl3,
				hadDreamAtLvl5 = drSViewModel.HadDreamAtLvl5,
				hadDreamAtLvl6 = drSViewModel.HadDreamAtLvl6,
				hadDreamAtLvl7 = drSViewModel.HadDreamAtLvl7,
				wantToDream = drSViewModel.WantToDream,
				dreamName = drSViewModel.DreamName,
				timeCopy = drSViewModel.TimeCopy,
				placeStartedDreamingID = drSViewModel.PlaceStartedDreamingID,
				effectsCopy = effectsCopy,
				inventorySlotsCopy = drSViewModel.InventorySlotsCopy,
				hotbarSlotsCopy = drSViewModel.HotbarSlotsCopy,
				positionCopy = drSViewModel.PositionCopy
			};

			OutSViewModel outSViewModel = mainViewModel.OutSViewModel ?? throw new NullReferenceException();
			OutS outS = new OutS
			{
				spawnedLocationsKeys = outSViewModel.SpawnedLocationsKeys,
				spawnedLocationsValuesIDs = outSViewModel.SpawnedLocationsValuesIDs,
				positionCopy = outSViewModel.PositionCopy,
				timeCopy = outSViewModel.TimeCopy,
				playerInOutsideLocation = outSViewModel.PlayerInOutsideLocation,
				currentLocationName = outSViewModel.CurrentLocationName,
				actualSpawnedLocationsCount = outSViewModel.ActualSpawnedLocationsCount,
				objectThatTransportedMeID = outSViewModel.ObjectThatTransportedMeID
			};

			RaSViewModel raSViewModel = mainViewModel.RaSViewModel ?? throw new NullReferenceException();
			RaS raS = new RaS
			{
				raining = raSViewModel.Raining,
				rainToday = raSViewModel.RainToday,
				timeToStart = raSViewModel.TimeToStart,
				lightningTime = raSViewModel.LightningTime,
				preRainLightning = raSViewModel.PreRainLightning,
				preRainLightningTime = raSViewModel.PreRainLightningTime,
				duration = raSViewModel.Duration,
				timeToFadeInFog = raSViewModel.TimeToFadeInFog,
				timeToFadeOutFog = raSViewModel.TimeToFadeOutFog,
				fogFadedOutToday = raSViewModel.FogFadedOutToday,
				fogIsActive = raSViewModel.FogIsActive
			};

			FlaSViewModel flaSViewModel = mainViewModel.FlaSViewModel ?? throw new NullReferenceException();
			FlaS flaS = new FlaS
			{
				karmaPoints = flaSViewModel.KarmaPoints,
				flags = flaSViewModel.Flags,
				npcStates = flaSViewModel.NpcStates,
				dialogueStates = flaSViewModel.DialogueStates,
				achievements = flaSViewModel.Achievements
			};

			JoSViewModel joSViewModel = mainViewModel.JoSViewModel ?? throw new NullReferenceException();
			JoS joS = new JoS
			{
				keysList = joSViewModel.KeysList,
				notesList = joSViewModel.NotesList,
				itemsList = joSViewModel.ItemsList,
				locationsList = joSViewModel.LocationsList,
				entriesList = joSViewModel.EntriesList,
				locationDirections = joSViewModel.LocationDirections
			};

			NumSViewModel numSViewModel = mainViewModel.NumSViewModel ?? throw new NullReferenceException();
			NumS numS = new NumS
			{
				numbers = numSViewModel.Numbers,
				yPositionOffsets = numSViewModel.YPositionOffsets
			};

			EvSViewModel evSViewModel = mainViewModel.EvSViewModel ?? throw new NullReferenceException();
			EvS evS = new EvS
			{
				events = evSViewModel.Events,
				activeEventCategories = evSViewModel.ActiveEventCategories,
				worldEventsIds = evSViewModel.WorldEventsIds,
				gameEventsToFireAfterLoad = evSViewModel.GameEventsToFireAfterLoad
			};

			ChspSViewModel chspSViewModel = mainViewModel.ChspSViewModel ?? throw new NullReferenceException();
			ChspS chspS = new ChspS
			{
				spawnedCharacterIDs = chspSViewModel.SpawnedCharacterIDs,
				nocturnalCharsIDs = chspSViewModel.NocturnalCharsIDs,
				holderID = chspSViewModel.HolderID,
				charactersEscapedFromLocationHolderID = chspSViewModel.CharactersEscapedFromLocationHolderID
			};

			WorldGenSViewModel worldGenSViewModel = mainViewModel.WorldGenSViewModel ?? throw new NullReferenceException();
			WorldGenS worldGenS = new WorldGenS
			{
				worldChunksIDs = worldGenSViewModel.WorldChunksIDs,
				locationsIDs = worldGenSViewModel.LocationsIDs,
				respawnPointsIDs = worldGenSViewModel.RespawnPointsIDs,
				chunkStates = worldGenSViewModel.ChunkStates,
				playerBaseID = worldGenSViewModel.PlayerBaseID,
				outsideLocationsGOID = worldGenSViewModel.OutsideLocationsGOID,
				roadsGOID = worldGenSViewModel.RoadsGOID,
				majorVersion = worldGenSViewModel.MajorVersion,
				minorVersion = worldGenSViewModel.MinorVersion,
				chapterID = worldGenSViewModel.ChapterID
			};

			GridSViewModel gridSViewModel = mainViewModel.GridSViewModel ?? throw new NullReferenceException();
			GridS gridS = new GridS
			{
				gridStates = gridSViewModel.GridStates
			};

			BbdSViewModel bbdSViewModel = mainViewModel.BbdSViewModel ?? throw new NullReferenceException();
			BbdS bbdS = new BbdS
			{
				bigBiomeStates = bbdSViewModel.BigBiomeStates
			};

			MapSViewModel mapSViewModel = mainViewModel.MapSViewModel ?? throw new NullReferenceException();
			MapS mapS = new MapS
			{
				elementIDs = mapSViewModel.ElementIDs,
				types = mapSViewModel.Types
			};

			NightScenSViewModel nightScenSViewModel = mainViewModel.NightScenSViewModel ?? throw new NullReferenceException();
			NightScenS nightScenS = new NightScenS
			{
				scenarioID = nightScenSViewModel.ScenarioID,
				previousScenarioName = nightScenSViewModel.PreviousScenarioName,
				previousScenarioDifficulty = nightScenSViewModel.PreviousScenarioDifficulty
			};

			ChDCViewModel chDCViewModel = mainViewModel.ChDCViewModel ?? throw new NullReferenceException();
			ChDC chDC = new ChDC
			{
				characterStates = chDCViewModel.CharacterStates
			};

			List<SavedObj> savedObjs = mainViewModel.SavedObjs ?? throw new NullReferenceException();

			RootViewModel rootViewModel = mainViewModel.RootViewModel ?? throw new NullReferenceException();
			Root root = new Root
			{
				majorVersion = rootViewModel.MajorVersion,
				minorVersion = rootViewModel.MinorVersion,
				majorVersionCompatibility = rootViewModel.MajorVersionCompatibility,
				minorVersionCompatibility = rootViewModel.MinorVersionCompatibility,
				RCVersion = rootViewModel.RCVersion,
				RCVersionCompatibility = rootViewModel.RCVersionCompatibility,
				saveMS = saveMS,
				pS = ps,
				iS = iS,
				hS = hS,
				cnS = cnS,
				drS = drS,
				outS = outS,
				raS = raS,
				flaS = flaS,
				joS = joS,
				numS = numS,
				evS = evS,
				chspS = chspS,
				worldGenS = worldGenS,
				gridS = gridS,
				bbdS = bbdS,
				mapS = mapS,
				nightScenS = nightScenS,
				chDC = chDC,
				savedObjs = savedObjs
			};

			return root;
		}
	}
}
