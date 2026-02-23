namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Turcichondrostoma;

/// <summary>
/// Interface defining characteristics of Turcichondrostoma (genus).
/// </summary>
public interface ITurcichondrostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
