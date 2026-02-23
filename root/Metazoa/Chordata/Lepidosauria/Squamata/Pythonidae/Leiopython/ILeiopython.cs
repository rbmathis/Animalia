namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Leiopython;

/// <summary>
/// Interface defining characteristics of Leiopython (genus).
/// </summary>
public interface ILeiopython
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
