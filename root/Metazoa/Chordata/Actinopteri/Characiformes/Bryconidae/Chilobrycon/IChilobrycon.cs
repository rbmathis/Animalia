namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Chilobrycon;

/// <summary>
/// Interface defining characteristics of Chilobrycon (genus).
/// </summary>
public interface IChilobrycon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
