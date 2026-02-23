namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae.Uratelornis;

/// <summary>
/// Interface defining characteristics of Uratelornis (genus).
/// </summary>
public interface IUratelornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
