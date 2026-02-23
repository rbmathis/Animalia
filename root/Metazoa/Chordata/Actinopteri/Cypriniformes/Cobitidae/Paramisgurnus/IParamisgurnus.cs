namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Paramisgurnus;

/// <summary>
/// Interface defining characteristics of Paramisgurnus (genus).
/// </summary>
public interface IParamisgurnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
