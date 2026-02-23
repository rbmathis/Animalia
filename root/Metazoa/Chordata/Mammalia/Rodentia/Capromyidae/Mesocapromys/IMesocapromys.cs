namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Mesocapromys;

/// <summary>
/// Interface defining characteristics of Mesocapromys (genus).
/// </summary>
public interface IMesocapromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
