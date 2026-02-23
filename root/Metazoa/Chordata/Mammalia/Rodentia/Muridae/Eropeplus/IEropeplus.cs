namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Eropeplus;

/// <summary>
/// Interface defining characteristics of Eropeplus (genus).
/// </summary>
public interface IEropeplus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
