namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Tanichthyidae.Tanichthys;

/// <summary>
/// Interface defining characteristics of Tanichthys (genus).
/// </summary>
public interface ITanichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
