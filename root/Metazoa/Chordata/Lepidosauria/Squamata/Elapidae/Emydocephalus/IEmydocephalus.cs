namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Emydocephalus;

/// <summary>
/// Interface defining characteristics of Emydocephalus (genus).
/// </summary>
public interface IEmydocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
