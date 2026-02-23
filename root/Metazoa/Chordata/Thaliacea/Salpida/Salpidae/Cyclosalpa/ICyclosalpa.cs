namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Cyclosalpa;

/// <summary>
/// Interface defining characteristics of Cyclosalpa (genus).
/// </summary>
public interface ICyclosalpa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
