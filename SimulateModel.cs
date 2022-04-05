using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateTemplate
{
    public class SimulateModel
    {

    }
    public class GLOBALPOINT
    {
        private int? X;
        private int? Y;
        private int? Z;
        public GLOBALPOINT() { }
        public GLOBALPOINT(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
    public class PATH
    {
        private List<GLOBALPOINT>? _points;
        public PATH(List<GLOBALPOINT> points) 
        {
            this._points = points;
        }
    }
    #region Infrastructure
    public abstract class Infrastructure
    {

    }
    #region Army
    public abstract class Army<Infrastructure>
    {
        public readonly bool _canShoot = true;
    }
    #region A_Vehicle
    public abstract class A_Vehicle : Army<Infrastructure>
    {
        
    }
    public abstract class AV_Water : A_Vehicle
    {
        public readonly bool _canSwim = true;
    }
    #region Air
    public abstract class AV_Air : A_Vehicle
    {
        public readonly bool _canFly = true;
    }
    public class AVA_Fighter : AV_Air
    {
        private bool? _canDrive;
        private bool? _hasWheel;
        private bool? _canSwim;
        private int? _qWheels;
        private bool? _isManned;
        private EDimension? _dimensions;
        private List<Arsenal>? _arsenal;
        private List<Human>? _crew;
        private ABG_Airfield? _homebase;
        private GLOBALPOINT? _location;
        private Dictionary<ECharacts, dynamic>? _characts;
        public AVA_Fighter(bool canDrive,
                           bool hasWheel,
                           bool canSwim,
                           int qWheels,
                           bool isManned,
                           EDimension? dimensions,
                           List<Arsenal> arsenal,
                           List<Human> crew,
                           ABG_Airfield homebase,
                           GLOBALPOINT location,
                           Dictionary<ECharacts, dynamic> characts)
        {
            this._canDrive = canDrive;
            this._hasWheel = hasWheel;
            this._canSwim = canSwim;
            this._qWheels = qWheels;
            this._isManned = isManned;
            this._dimensions = dimensions;
            this._arsenal = arsenal;
            this._crew = crew;
            this._homebase = homebase;
            this._location = location;
            this._characts = characts;
        }
    }
    public class AVA_Attacker : AV_Air
    {
        private bool? _canDrive;
        private bool? _hasWheel;
        private bool? _canSwim;
        private int? _qWheels;
        private bool? _isManned;
        private EDimension? _dimensions;
        private List<Arsenal>? _arsenal;
        private List<Human>? _crew;
        private ABG_Airfield? _homebase;
        private GLOBALPOINT? _location;
        private Dictionary<ECharacts, dynamic>? _characts;
        public AVA_Attacker(bool canDrive,
                           bool hasWheel,
                           bool canSwim,
                           int qWheels,
                           bool isManned,
                           EDimension? dimensions,
                           List<Arsenal> arsenal,
                           List<Human> crew,
                           ABG_Airfield homebase,
                           GLOBALPOINT location,
                           Dictionary<ECharacts, dynamic> characts)
        {
            this._canDrive = canDrive;
            this._hasWheel = hasWheel;
            this._canSwim = canSwim;
            this._qWheels = qWheels;
            this._isManned = isManned;
            this._dimensions = dimensions;
            this._arsenal = arsenal;
            this._crew = crew;
            this._homebase = homebase;
            this._location = location;
            this._characts = characts;
        }
    }
    public class AVA_Bomber : AV_Air
    {
        private bool? _canDrive;
        private bool? _hasWheel;
        private bool? _canSwim;
        private int? _qWheels;
        private bool? _isManned;
        private EDimension? _dimensions;
        private List<Arsenal>? _arsenal;
        private List<Human>? _crew;
        private ABG_Airfield? _homebase;
        private GLOBALPOINT? _location;
        private Dictionary<ECharacts, dynamic>? _characts;
        public AVA_Bomber(bool canDrive,
                           bool hasWheel,
                           bool canSwim,
                           int qWheels,
                           bool isManned,
                           EDimension? dimensions,
                           List<Arsenal> arsenal,
                           List<Human> crew,
                           ABG_Airfield homebase,
                           GLOBALPOINT location,
                           Dictionary<ECharacts, dynamic> characts)
        {
            this._canDrive = canDrive;
            this._hasWheel = hasWheel;
            this._canSwim = canSwim;
            this._qWheels = qWheels;
            this._isManned = isManned;
            this._dimensions = dimensions;
            this._arsenal = arsenal;
            this._crew = crew;
            this._homebase = homebase;
            this._location = location;
            this._characts = characts;
        }
    }
    public class AVA_Helocopter : AV_Air
    {
        private bool? _canDrive;
        private bool? _hasWheel;
        private bool? _canSwim;
        private int? _qWheels;
        private bool? _isManned;
        private EDimension? _dimensions;
        private List<Arsenal>? _arsenal;
        private List<Human>? _crew;
        private ABG_Airfield? _homebase;
        private GLOBALPOINT? _location;
        private Dictionary<ECharacts, dynamic>? _characts;
        public AVA_Helocopter(bool canDrive,
                           bool hasWheel,
                           bool canSwim,
                           int qWheels,
                           bool isManned,
                           EDimension? dimensions,
                           List<Arsenal> arsenal,
                           List<Human> crew,
                           ABG_Airfield homebase,
                           GLOBALPOINT location,
                           Dictionary<ECharacts, dynamic> characts)
        {
            this._canDrive = canDrive;
            this._hasWheel = hasWheel;
            this._canSwim = canSwim;
            this._qWheels = qWheels;
            this._isManned = isManned;
            this._dimensions = dimensions;
            this._arsenal = arsenal;
            this._crew = crew;
            this._homebase = homebase;
            this._location = location;
            this._characts = characts;
        }
    }
    #endregion
    public abstract class AV_Ground : A_Vehicle
    {
        public readonly bool _canDrive = true;
    }
    public abstract class AV_Space : A_Vehicle
    { 

    }
    #endregion
    #region A_Building
    public abstract class A_Building : Army<Infrastructure>
    {

    }
    public abstract class AB_Water : A_Building
    {

    }
    public abstract class AB_Ground : A_Building
    {

    }
    public class ABG_Fortification : AB_Ground
    {

    }
    public class ABG_Base : AB_Ground
    {

    }
    public class ABG_Airfield : AB_Ground
    {

    }
    #endregion
    #endregion
    #endregion
    #region BASECLASSES
    public abstract class Arsenal
    {

    }
    public class Gun : Arsenal
    {

    }
    public class Rocket : Arsenal
    {

    }
    public class Bomb : Arsenal
    {

    }
    public abstract class Ammunition
    {

    }
    public class Bullet : Ammunition
    {

    }
    #endregion
    #region Human
    public class Human
    {
        private string? _name;
        private string? _surname;
        private Country? _country;
        private Occupation? _occupation;
        private List<License>? _licenses;
        private Dictionary<EDimension, int>? _dimensions;
        private Dictionary<ECharacts, dynamic>? _characts;
        public Human(string name,
                     string surname,
                     Country country,
                     Occupation occupation,
                     List<License> licenses,
                     Dictionary<EDimension, int> dimensions,
                     Dictionary<ECharacts, dynamic> characts)
        {
            this._name = name;
            this._surname = surname;
            this._country = country;
            this._occupation = occupation;
            this._licenses = licenses;
            this._dimensions = dimensions;
            this._characts = characts;
        }
    }
    #endregion
    #region Occupation
    public enum Occupation
    {
        Pilot,
        Driver
    }
    #endregion
    #region Country
    public class Country
    {
        public string? _name;
        public Country(string name)
        {
            this._name = name;
        }
    }
    #endregion
    #region License
    public enum ELicenses
    {
        Passport,
        Driver,
        Pilot
    }
    public class License
    {
        private ELicenses? _type;
        private string? _value;
        public License(ELicenses type, string value)
        {
            this._type = type;
            this._value = value;
        }
    }
    #endregion
    #region Dimension
    public enum EDimension
    {
        Length,
        Width,
        Height,
        Weight
    }
    #endregion
    #region Characts
    public enum ECharacts
    {
        Name,
        Seats,
        Condition,
        Maxload,
        Speed,
        Aerodynamics
    }
    #endregion
}