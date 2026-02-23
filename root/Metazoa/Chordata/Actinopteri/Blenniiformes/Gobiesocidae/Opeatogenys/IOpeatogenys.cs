namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Opeatogenys;

/// <summary>
/// Interface defining characteristics of Opeatogenys (genus).
/// </summary>
public interface IOpeatogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
