namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Clavelina;

/// <summary>
/// Interface defining characteristics of Clavelina (genus).
/// </summary>
public interface IClavelina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
