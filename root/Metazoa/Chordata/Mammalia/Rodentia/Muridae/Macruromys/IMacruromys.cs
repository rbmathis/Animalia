namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Macruromys;

/// <summary>
/// Interface defining characteristics of Macruromys (genus).
/// </summary>
public interface IMacruromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
