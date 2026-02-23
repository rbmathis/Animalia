namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes;

/// <summary>
/// Interface defining characteristics of Scombriformes (order).
/// </summary>
public interface IScombriformes
{
    /// <inheritdoc />
    string OrderName { get; }

    /// <inheritdoc />
    string[] OrderCharacteristics { get; }

    /// <inheritdoc />
    bool HasCarnassialTeeth { get; }

    /// <inheritdoc />
    string DietType { get; }

    /// <inheritdoc />
    string[] DigestiveAdaptations { get; }

    /// <inheritdoc />
    string HuntingStrategy { get; }

    /// <inheritdoc />
    string[] PreyTypes { get; }

    /// <inheritdoc />
    bool IsCooperativeHunter { get; }

    /// <inheritdoc />
    string[] HuntingSensoryAdaptations { get; }

}
