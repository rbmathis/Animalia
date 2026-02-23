namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Hellmayrea;

/// <summary>
/// Interface defining characteristics of Hellmayrea (genus).
/// </summary>
public interface IHellmayrea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
