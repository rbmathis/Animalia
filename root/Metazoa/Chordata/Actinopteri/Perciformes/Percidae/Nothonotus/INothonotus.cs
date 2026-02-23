namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Nothonotus;

/// <summary>
/// Interface defining characteristics of Nothonotus (genus).
/// </summary>
public interface INothonotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
