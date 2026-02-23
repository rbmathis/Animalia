namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Neoeucirrhichthys;

/// <summary>
/// Interface defining characteristics of Neoeucirrhichthys (genus).
/// </summary>
public interface INeoeucirrhichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
