namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Campethera;

/// <summary>
/// Interface defining characteristics of Campethera (genus).
/// </summary>
public interface ICampethera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
