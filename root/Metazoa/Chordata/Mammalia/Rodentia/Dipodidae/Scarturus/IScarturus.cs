namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Scarturus;

/// <summary>
/// Interface defining characteristics of Scarturus (genus).
/// </summary>
public interface IScarturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
