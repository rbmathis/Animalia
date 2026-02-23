namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Sphenodontia.Sphenodontidae.Sphenodon;

/// <summary>
/// Interface defining characteristics of Sphenodon (genus).
/// </summary>
public interface ISphenodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
