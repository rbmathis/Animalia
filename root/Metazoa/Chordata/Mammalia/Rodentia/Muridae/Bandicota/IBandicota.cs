namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bandicota;

/// <summary>
/// Interface defining characteristics of Bandicota (genus).
/// </summary>
public interface IBandicota
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
