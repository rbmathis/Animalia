namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Bradypterus;

/// <summary>
/// Interface defining characteristics of Bradypterus (genus).
/// </summary>
public interface IBradypterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
