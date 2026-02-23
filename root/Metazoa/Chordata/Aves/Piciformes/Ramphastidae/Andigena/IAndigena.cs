namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Andigena;

/// <summary>
/// Interface defining characteristics of Andigena (genus).
/// </summary>
public interface IAndigena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
