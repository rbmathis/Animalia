namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Upupidae.Upupa;

/// <summary>
/// Interface defining characteristics of Upupa (genus).
/// </summary>
public interface IUpupa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
