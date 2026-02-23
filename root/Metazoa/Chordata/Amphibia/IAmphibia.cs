namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia;

/// <summary>
/// Interface defining characteristics of Amphibia (class).
/// </summary>
public interface IAmphibia
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
