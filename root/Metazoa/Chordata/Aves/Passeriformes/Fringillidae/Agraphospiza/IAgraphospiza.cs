namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Agraphospiza;

/// <summary>
/// Interface defining characteristics of Agraphospiza (genus).
/// </summary>
public interface IAgraphospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
