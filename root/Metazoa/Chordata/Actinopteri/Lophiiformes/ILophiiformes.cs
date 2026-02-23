namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes;

/// <summary>
/// Interface defining characteristics of Lophiiformes (order).
/// </summary>
public interface ILophiiformes
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
