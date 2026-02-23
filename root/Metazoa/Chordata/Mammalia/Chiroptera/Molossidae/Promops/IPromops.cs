namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Promops;

/// <summary>
/// Interface defining characteristics of Promops (genus).
/// </summary>
public interface IPromops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
