namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Chimaerodipus;

/// <summary>
/// Interface defining characteristics of Chimaerodipus (genus).
/// </summary>
public interface IChimaerodipus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
