namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Hylomanes;

/// <summary>
/// Interface defining characteristics of Hylomanes (genus).
/// </summary>
public interface IHylomanes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
