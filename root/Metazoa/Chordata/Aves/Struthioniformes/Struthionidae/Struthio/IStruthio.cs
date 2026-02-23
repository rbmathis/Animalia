namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Struthionidae.Struthio;

/// <summary>
/// Interface defining characteristics of Struthio (genus).
/// </summary>
public interface IStruthio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
