namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Dactylopsila;

/// <summary>
/// Interface defining characteristics of Dactylopsila (genus).
/// </summary>
public interface IDactylopsila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
