namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Rhynchohyalus;

/// <summary>
/// Interface defining characteristics of Rhynchohyalus (genus).
/// </summary>
public interface IRhynchohyalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
