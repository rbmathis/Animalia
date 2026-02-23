namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Radiicephalidae.Radiicephalus;

/// <summary>
/// Interface defining characteristics of Radiicephalus (genus).
/// </summary>
public interface IRadiicephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
