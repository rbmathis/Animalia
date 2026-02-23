namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Leptopoecile;

/// <summary>
/// Interface defining characteristics of Leptopoecile (genus).
/// </summary>
public interface ILeptopoecile
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
