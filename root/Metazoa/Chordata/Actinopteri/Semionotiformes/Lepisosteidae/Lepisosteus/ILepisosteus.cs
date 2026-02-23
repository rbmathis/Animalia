namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Lepisosteus;

/// <summary>
/// Interface defining characteristics of Lepisosteus (genus).
/// </summary>
public interface ILepisosteus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
