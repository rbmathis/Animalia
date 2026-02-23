namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Hymenochirus;

/// <summary>
/// Interface defining characteristics of Hymenochirus (genus).
/// </summary>
public interface IHymenochirus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
