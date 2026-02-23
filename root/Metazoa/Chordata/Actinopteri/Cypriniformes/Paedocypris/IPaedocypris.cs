namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Paedocypris;

/// <summary>
/// Interface defining characteristics of Paedocypris (genus).
/// </summary>
public interface IPaedocypris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
