namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Niviventer;

/// <summary>
/// Interface defining characteristics of Niviventer (genus).
/// </summary>
public interface INiviventer
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
