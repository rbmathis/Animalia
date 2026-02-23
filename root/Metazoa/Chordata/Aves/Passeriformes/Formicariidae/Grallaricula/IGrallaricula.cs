namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Grallaricula;

/// <summary>
/// Interface defining characteristics of Grallaricula (genus).
/// </summary>
public interface IGrallaricula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
