namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Metriopelia;

/// <summary>
/// Interface defining characteristics of Metriopelia (genus).
/// </summary>
public interface IMetriopelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
