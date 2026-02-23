namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vandeleuria;

/// <summary>
/// Interface defining characteristics of Vandeleuria (genus).
/// </summary>
public interface IVandeleuria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
