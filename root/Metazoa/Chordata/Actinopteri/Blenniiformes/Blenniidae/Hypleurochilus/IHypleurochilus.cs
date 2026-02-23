namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Hypleurochilus;

/// <summary>
/// Interface defining characteristics of Hypleurochilus (genus).
/// </summary>
public interface IHypleurochilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
