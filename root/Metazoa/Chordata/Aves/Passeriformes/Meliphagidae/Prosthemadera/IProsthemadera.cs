namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Prosthemadera;

/// <summary>
/// Interface defining characteristics of Prosthemadera (genus).
/// </summary>
public interface IProsthemadera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
