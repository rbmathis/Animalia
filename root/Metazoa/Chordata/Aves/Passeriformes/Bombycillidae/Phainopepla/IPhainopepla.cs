namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Phainopepla;

/// <summary>
/// Interface defining characteristics of Phainopepla (genus).
/// </summary>
public interface IPhainopepla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
