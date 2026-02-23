namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Meriones;

/// <summary>
/// Interface defining characteristics of Meriones (genus).
/// </summary>
public interface IMeriones
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
