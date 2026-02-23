namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lamottemys;

/// <summary>
/// Interface defining characteristics of Lamottemys (genus).
/// </summary>
public interface ILamottemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
