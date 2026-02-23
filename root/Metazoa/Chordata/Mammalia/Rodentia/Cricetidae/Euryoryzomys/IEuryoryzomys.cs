namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euryoryzomys;

/// <summary>
/// Interface defining characteristics of Euryoryzomys (genus).
/// </summary>
public interface IEuryoryzomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
