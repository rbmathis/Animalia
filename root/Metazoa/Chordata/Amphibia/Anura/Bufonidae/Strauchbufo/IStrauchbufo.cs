namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Strauchbufo;

/// <summary>
/// Interface defining characteristics of Strauchbufo (genus).
/// </summary>
public interface IStrauchbufo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
