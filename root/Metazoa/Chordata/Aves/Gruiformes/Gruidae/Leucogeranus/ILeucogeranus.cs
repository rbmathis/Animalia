namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Leucogeranus;

/// <summary>
/// Interface defining characteristics of Leucogeranus (genus).
/// </summary>
public interface ILeucogeranus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
