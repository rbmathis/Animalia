namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Petaurus;

/// <summary>
/// Interface defining characteristics of Petaurus (genus).
/// </summary>
public interface IPetaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
