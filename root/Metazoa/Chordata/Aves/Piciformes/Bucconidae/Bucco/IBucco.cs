namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Bucco;

/// <summary>
/// Interface defining characteristics of Bucco (genus).
/// </summary>
public interface IBucco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
