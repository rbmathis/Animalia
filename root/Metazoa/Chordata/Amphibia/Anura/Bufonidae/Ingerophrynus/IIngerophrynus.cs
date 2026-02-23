namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ingerophrynus;

/// <summary>
/// Interface defining characteristics of Ingerophrynus (genus).
/// </summary>
public interface IIngerophrynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
