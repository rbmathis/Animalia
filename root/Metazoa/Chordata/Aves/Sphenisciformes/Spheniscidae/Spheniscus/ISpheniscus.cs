namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Spheniscus;

/// <summary>
/// Interface defining characteristics of Spheniscus (genus).
/// </summary>
public interface ISpheniscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
