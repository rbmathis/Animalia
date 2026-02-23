namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Irenidae.Irena;

/// <summary>
/// Interface defining characteristics of Irena (genus).
/// </summary>
public interface IIrena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
