namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lenothrix;

/// <summary>
/// Interface defining characteristics of Lenothrix (genus).
/// </summary>
public interface ILenothrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
