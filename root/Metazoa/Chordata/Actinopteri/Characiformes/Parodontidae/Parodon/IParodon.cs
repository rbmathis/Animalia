namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Parodon;

/// <summary>
/// Interface defining characteristics of Parodon (genus).
/// </summary>
public interface IParodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
