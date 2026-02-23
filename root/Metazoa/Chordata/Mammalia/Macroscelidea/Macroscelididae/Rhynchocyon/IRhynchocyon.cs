namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Rhynchocyon;

/// <summary>
/// Interface defining characteristics of Rhynchocyon (genus).
/// </summary>
public interface IRhynchocyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
