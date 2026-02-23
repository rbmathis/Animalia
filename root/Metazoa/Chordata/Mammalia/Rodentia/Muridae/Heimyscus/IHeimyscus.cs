namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Heimyscus;

/// <summary>
/// Interface defining characteristics of Heimyscus (genus).
/// </summary>
public interface IHeimyscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
