namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Cnesterodon;

/// <summary>
/// Interface defining characteristics of Cnesterodon (genus).
/// </summary>
public interface ICnesterodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
