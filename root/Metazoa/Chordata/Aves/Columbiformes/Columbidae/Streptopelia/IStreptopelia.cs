namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Streptopelia;

/// <summary>
/// Interface defining characteristics of Streptopelia (genus).
/// </summary>
public interface IStreptopelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
