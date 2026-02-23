namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon;

/// <summary>
/// Interface defining characteristics of Brycon (genus).
/// </summary>
public interface IBrycon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
