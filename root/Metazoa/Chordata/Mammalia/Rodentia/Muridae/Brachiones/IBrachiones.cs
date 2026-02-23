namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Brachiones;

/// <summary>
/// Interface defining characteristics of Brachiones (genus).
/// </summary>
public interface IBrachiones
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
