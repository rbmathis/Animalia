namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Helicosalpa;

/// <summary>
/// Interface defining characteristics of Helicosalpa (genus).
/// </summary>
public interface IHelicosalpa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
