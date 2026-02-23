namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Physiculus;

/// <summary>
/// Interface defining characteristics of Physiculus (genus).
/// </summary>
public interface IPhysiculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
