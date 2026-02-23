namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crateromys;

/// <summary>
/// Interface defining characteristics of Crateromys (genus).
/// </summary>
public interface ICrateromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
