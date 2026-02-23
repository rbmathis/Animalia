namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Gobiomorphus;

/// <summary>
/// Interface defining characteristics of Gobiomorphus (genus).
/// </summary>
public interface IGobiomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
