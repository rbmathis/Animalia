namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Parachaetodon;

/// <summary>
/// Interface defining characteristics of Parachaetodon (genus).
/// </summary>
public interface IParachaetodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
