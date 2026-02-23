namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Montemys;

/// <summary>
/// Interface defining characteristics of Montemys (genus).
/// </summary>
public interface IMontemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
