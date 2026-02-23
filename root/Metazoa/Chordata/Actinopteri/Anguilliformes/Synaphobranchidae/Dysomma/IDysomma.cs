namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Dysomma;

/// <summary>
/// Interface defining characteristics of Dysomma (genus).
/// </summary>
public interface IDysomma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
