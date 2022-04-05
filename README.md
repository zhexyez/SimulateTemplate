                          |                  |
                          SIMULATION STRUCTURE
                          ----*imaginary*-----
                          Structural Hierarchy  : described on GLOBE STRUCTURE
                          Application Hierarchy : -------------
                                                              |
                          Globe           Init             <---
                          Globe           Init    params
                          Land            Init
                          Land            Init    params
                          Country         Init
                          Country         Init    params
                          City            Define
                          City            Init    params
                          Town            Define
                          Town            Init    params
                          Village         Define
                          Village         Init    params
                          Infrastructure  Define
                          Infrastructure  Init    params
                          Road            Define
                          Road            Init    params
                          Civil           Define
                          Civil           Init    params
                          Army            Define
                          Army            Init    params
      
                            |             |
                            GLOBE STRUCTURE
                            --*imaginary*--
      Globe -> Weather, Natural Phenomena
          | Land -> Terrain
              | Country -> Border Path, Politians, Budgets, Tech Levels
                  | Cities
                      | Border Path
                      | Population
                      | Budget
                  | Towns
                      | Border Path
                      | Population
                      | Budget
                  | Villages
                      | Border Path
                      | Population
                      | Budget
                  | Infrastructure
                      | Roads
                          | Asphalt
                              | Width
                              | Path
                              | Condition
                          | Dirt
                              | Width
                              | Path
                              | Condition
                          | Rail
                              | Width
                              | Path
                              | Condition
                      | Civil
                          | Vehicles
                              | Water
                                  | Ships
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Submarines
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                              | Air
                                  | Planes
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Helicopters
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                              | Ground
                                  | Cars
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Trains
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                              | Space
                                  | Satellites
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                          | Buildings
                              | Water
                                  | Buildings
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Personnel
                                      | Location
                              | Ground
                                  | Buildings
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Personnel
                                      | Location
                                  | Airports
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Personnel
                                      | Location
                      | Army
                          | Vehicles
                              | Water
                                  | Ships
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Submarines
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Crew
                                      | Homebase
                                      | Location
                              | Air
                                  | Fighters
                                      | Type
                                      | Arsenal
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Attackers
                                      | Type
                                      | Arsenal
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Bombers
                                      | Type
                                      | Arsenal
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Helicopters
                                      | Type
                                      | Arsenal
                                      | Crew
                                      | Homebase
                                      | Location
                                  | Transports
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Crew
                                      | Homebase
                                      | Location
                              | Ground
                                  | Jeeps
                                      | Type
                                      | Crew
                                      | Arsenal
                                      | Homebase
                                      | Location
                                  | Armored Personnel Carriers
                                      | Type
                                      | Crew
                                      | Arsenal
                                      | Homebase
                                      | Location
                                  | Tanks
                                      | Type
                                      | Crew
                                      | Arsenal
                                      | Homebase
                                      | Location
                                  | Air Defence
                                      | Type
                                      | Crew
                                      | Arsenal
                                      | Homebase
                                      | Location
                                  | Transports
                                      | Type
                                      | Crew
                                      | Cargo
                                          | Supply*
                                      | Homebase
                                      | Location
                                  | Trains
                                      | Type
                                      | Crew
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Homebase
                                      | Location
                              | Space
                                  | Satellites
                                      | Type
                                      | Crew
                                      | Arsenal
                                      | Homebase
                                      | Location
                          | Buildings
                              | Water
                                  | Fortifications
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Personnel
                                      | Location
                              | Ground
                                  | Fortifications
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Personnel
                                      | Location
                                  | Bases
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Personnel
                                      | Location
                                  | Airfields
                                      | Size
                                      | Type
                                      | Cargo
                                          | Supply*
                                      | Arsenal
                                      | Personnel
                                      | Location
                                      
      & Size              -> M^2, M^3
      & Type              -> Type Name, Characteristics [e.g. Dimensions, Speed, Aerodynamics, etc.]
      & Cargo, Supply     -> Goods [Type, Dimensions, Origin]
      & Arsenal           -> Armament [Type, Quantity, Dimensions, Ammunition [Type, Quantity, Dimensions]]
      & Crew, Personnel   -> Humans [First Name, Last Name, Country, Position, Licences, Dimensions]
      & Homebase          -> Linking Point [{matching type}]
      & Location          -> Globe Point
      & Population        -> Quantity of Humans
      & Border Path       -> Set of Global Points
      & Path              -> Set of Global Points
      & Width             -> Can be various along the Path
      
      E.G. FOR TYPE - ARMY VEHICLE AIR FIGHTER
      -----------------------------------------------------------------------------
      |   TYPE:       ARMY VEHICLE AIR FIGHTER MANNED                             |
      |   ARSENAL:                                                                |
      |          | GUN "BETTY":                                                   |
      |                       | 2                                                 |
      |                       | AMMUNITION:                                       | 
      |                                   | BULLET "ROSEN"                        |
      |                                   | 350                                   |
      |          | ROCKET "LOVE" AIR-TO-AIR UNGUIDED:                             |
      |                                             | 1                           |
      |          | ROCKET "FLAME" AIR-TO-GROUND GUIDED:                           |
      |                                               | 1                         |
      |   CREW:                                                                   |
      |       | HUMAN:                                                            |
      |              | JOHN                                                       |
      |              | STARK                                                      |
      |              | USA                                                        |
      |              | PILOT                                                      |
      |              | [LICENSES AS STRINGS]                                      |
      |              | 1780MM X 800MM                                             |
      |       | HUMAN:                                                            |
      |              | BRED                                                       |
      |              | MALLOY                                                     |
      |              | USA                                                        |
      |              | AIR MECHANIC                                               |
      |              | [LICENSES AS STRINGS]                                      |
      |              | 1800MM X 740MM                                             |
      |   HOMEBASE:   BUILDING<AIRFIELD "SEPARRO">                                |
      |   LOCATION:   XYZ<GLOBAL POINT>                                           |
      |   CHARACTS:                                                               |
      |           | NAME: "BLACK BIRD", "SERIAL NUMBER"                           |
      |           | DIMENSIONS: 9000MM X 7000M X 4000M                            |
      |           | SPEED: 0, 2160KPH                                             |
      |           | AERODYNAMICS: 4.5                                             |
      |           | SEATS: 1                                                      |
      |           | MAXLOAD: 350KG                                                |
      |           | CONDITION: 1                                                  |
      -----------------------------------------------------------------------------
      
      E.G. FOR TYPE - GUN "BETTY"
      -------------------------------------------------
      |     TYPE: BASETYPE                            |
      |     ARMAMENT COMPATIBLE:                      |
      |                        | BULLET "ROSEN"       |
      |                        | BULLET "BERRY"       |
      |     CHARACTS:                                 |
      |             | NAME: "BETTY"                   |
      |             | DIMENSIONS: 1000MM X 30MM       |
      |             | BPS: 30                         |
      |             | WEIGHT: 97KG                    |
      |             | CONDITION: 5                    |
      -------------------------------------------------
      
      TODO 1: AV_Water, AV_Ground, AV_Space
      TODO 2: A_Building (with its descendants)
      TODO 3: BASECLASSES