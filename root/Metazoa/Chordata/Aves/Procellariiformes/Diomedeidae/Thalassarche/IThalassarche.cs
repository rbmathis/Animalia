namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Thalassarche;

/// <summary>
/// Interface defining characteristics of Thalassarche (genus).
/// </summary>
public interface IThalassarche
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
