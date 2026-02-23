namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii;

/// <summary>
/// Interface defining characteristics of Leptocardii (class).
/// </summary>
public interface ILeptocardii
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
