namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Gecinulus;

/// <summary>
/// Interface defining characteristics of Gecinulus (genus).
/// </summary>
public interface IGecinulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
