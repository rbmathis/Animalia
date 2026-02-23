namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

/// <summary>
/// Interface defining characteristics of Acomys (genus).
/// </summary>
public interface IAcomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
