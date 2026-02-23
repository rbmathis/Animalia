namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Halmaheramys;

/// <summary>
/// Interface defining characteristics of Halmaheramys (genus).
/// </summary>
public interface IHalmaheramys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
