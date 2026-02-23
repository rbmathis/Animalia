namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

/// <summary>
/// Interface defining characteristics of Actinopteri (class).
/// </summary>
public interface IActinopteri
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
