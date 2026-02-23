namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Petroschmidtia;

/// <summary>
/// Interface defining characteristics of Petroschmidtia (genus).
/// </summary>
public interface IPetroschmidtia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
