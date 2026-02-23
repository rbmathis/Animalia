namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Anthobaphes;

/// <summary>
/// Interface defining characteristics of Anthobaphes (genus).
/// </summary>
public interface IAnthobaphes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
