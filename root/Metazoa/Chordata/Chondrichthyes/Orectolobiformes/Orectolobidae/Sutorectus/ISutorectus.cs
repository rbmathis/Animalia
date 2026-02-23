namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Sutorectus;

/// <summary>
/// Interface defining characteristics of Sutorectus (genus).
/// </summary>
public interface ISutorectus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
