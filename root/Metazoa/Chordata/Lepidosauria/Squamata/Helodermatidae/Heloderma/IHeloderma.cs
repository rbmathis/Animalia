namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Helodermatidae.Heloderma;

/// <summary>
/// Interface defining characteristics of Heloderma (genus).
/// </summary>
public interface IHeloderma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
