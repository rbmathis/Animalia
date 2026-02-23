namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Cystodytes;

/// <summary>
/// Interface defining characteristics of Cystodytes (genus).
/// </summary>
public interface ICystodytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
