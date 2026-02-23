namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Parachondrostoma;

/// <summary>
/// Interface defining characteristics of Parachondrostoma (genus).
/// </summary>
public interface IParachondrostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
