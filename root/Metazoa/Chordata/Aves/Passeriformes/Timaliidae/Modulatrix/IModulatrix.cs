namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Modulatrix;

/// <summary>
/// Interface defining characteristics of Modulatrix (genus).
/// </summary>
public interface IModulatrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
