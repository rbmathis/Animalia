namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Melanocetidae.Melanocetus;

/// <summary>
/// Interface defining characteristics of Melanocetus (genus).
/// </summary>
public interface IMelanocetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
