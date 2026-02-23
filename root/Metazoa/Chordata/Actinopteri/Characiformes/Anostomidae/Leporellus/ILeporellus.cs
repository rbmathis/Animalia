namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Leporellus;

/// <summary>
/// Interface defining characteristics of Leporellus (genus).
/// </summary>
public interface ILeporellus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
