namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae.Anomalospiza;

/// <summary>
/// Interface defining characteristics of Anomalospiza (genus).
/// </summary>
public interface IAnomalospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
