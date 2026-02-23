namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Uropelia;

/// <summary>
/// Interface defining characteristics of Uropelia (genus).
/// </summary>
public interface IUropelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
