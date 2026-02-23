namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Symplegma;

/// <summary>
/// Interface defining characteristics of Symplegma (genus).
/// </summary>
public interface ISymplegma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
