namespace AnimalKingdom.root.Metazoa.Chordata.Myxini;

/// <summary>
/// Interface defining characteristics of Myxini (class).
/// </summary>
public interface IMyxini
{
    /// <inheritdoc />
    string ClassName { get; }

    /// <inheritdoc />
    string[] ClassCharacteristics { get; }

    /// <inheritdoc />
    bool HasMammaryGlands { get; }

    /// <inheritdoc />
    bool HasHairOrFur { get; }

    /// <inheritdoc />
    string DentitionPattern { get; }

    /// <inheritdoc />
    bool HasFourChamberedHeart { get; }

    /// <inheritdoc />
    string GestationType { get; }

    /// <inheritdoc />
    bool IsEndothermic { get; }

    /// <inheritdoc />
    string[] ThermoregulationMechanisms { get; }

}
