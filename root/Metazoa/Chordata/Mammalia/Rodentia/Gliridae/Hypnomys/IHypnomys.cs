namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Hypnomys;

/// <summary>
/// Interface defining characteristics of Hypnomys (genus).
/// </summary>
public interface IHypnomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
