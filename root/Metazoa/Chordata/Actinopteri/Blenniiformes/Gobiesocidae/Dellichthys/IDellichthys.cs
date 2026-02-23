namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Dellichthys;

/// <summary>
/// Interface defining characteristics of Dellichthys (genus).
/// </summary>
public interface IDellichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
