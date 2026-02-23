namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes;

/// <summary>
/// Interface defining characteristics of Percopsiformes (order).
/// </summary>
public interface IPercopsiformes
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
