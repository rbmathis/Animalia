namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corcoracidae.Corcorax;

/// <summary>
/// Interface defining characteristics of Corcorax (genus).
/// </summary>
public interface ICorcorax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
