namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicoparrus;

/// <summary>
/// Interface defining characteristics of Phoenicoparrus (genus).
/// </summary>
public interface IPhoenicoparrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
