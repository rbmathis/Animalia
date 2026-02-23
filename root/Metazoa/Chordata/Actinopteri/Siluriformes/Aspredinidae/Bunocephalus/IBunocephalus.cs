namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Bunocephalus;

/// <summary>
/// Interface defining characteristics of Bunocephalus (genus).
/// </summary>
public interface IBunocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
