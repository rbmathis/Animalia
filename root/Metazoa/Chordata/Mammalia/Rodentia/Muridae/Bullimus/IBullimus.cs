namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bullimus;

/// <summary>
/// Interface defining characteristics of Bullimus (genus).
/// </summary>
public interface IBullimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
