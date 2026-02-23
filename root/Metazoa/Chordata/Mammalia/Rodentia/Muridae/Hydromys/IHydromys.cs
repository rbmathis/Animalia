namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys;

/// <summary>
/// Interface defining characteristics of Hydromys (genus).
/// </summary>
public interface IHydromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
