namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Ariommatidae.Ariomma;

/// <summary>
/// Interface defining characteristics of Ariomma (genus).
/// </summary>
public interface IAriomma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
