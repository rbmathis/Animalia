namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Annamia;

/// <summary>
/// Interface defining characteristics of Annamia (genus).
/// </summary>
public interface IAnnamia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
