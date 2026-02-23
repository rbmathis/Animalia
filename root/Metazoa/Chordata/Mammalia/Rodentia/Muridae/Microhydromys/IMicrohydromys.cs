namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Microhydromys;

/// <summary>
/// Interface defining characteristics of Microhydromys (genus).
/// </summary>
public interface IMicrohydromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
