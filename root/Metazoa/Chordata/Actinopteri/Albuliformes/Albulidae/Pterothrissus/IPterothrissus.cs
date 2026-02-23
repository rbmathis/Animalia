namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae.Pterothrissus;

/// <summary>
/// Interface defining characteristics of Pterothrissus (genus).
/// </summary>
public interface IPterothrissus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
