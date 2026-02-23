namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Microbiotheria.Microbiotheriidae.Dromiciops;

/// <summary>
/// Interface defining characteristics of Dromiciops (genus).
/// </summary>
public interface IDromiciops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
