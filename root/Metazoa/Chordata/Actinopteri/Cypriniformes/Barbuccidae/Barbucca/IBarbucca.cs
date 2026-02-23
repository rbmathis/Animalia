namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Barbuccidae.Barbucca;

/// <summary>
/// Interface defining characteristics of Barbucca (genus).
/// </summary>
public interface IBarbucca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
