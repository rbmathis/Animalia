namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Hexacrobylidae.Oligotrema;

/// <summary>
/// Interface defining characteristics of Oligotrema (genus).
/// </summary>
public interface IOligotrema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
