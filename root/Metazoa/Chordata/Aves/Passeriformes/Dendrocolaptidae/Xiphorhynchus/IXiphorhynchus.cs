namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Xiphorhynchus;

/// <summary>
/// Interface defining characteristics of Xiphorhynchus (genus).
/// </summary>
public interface IXiphorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
