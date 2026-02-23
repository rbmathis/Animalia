namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Rhodosoma;

/// <summary>
/// Interface defining characteristics of Rhodosoma (genus).
/// </summary>
public interface IRhodosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
