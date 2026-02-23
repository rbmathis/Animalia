namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Zeledonia;

/// <summary>
/// Interface defining characteristics of Zeledonia (genus).
/// </summary>
public interface IZeledonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
