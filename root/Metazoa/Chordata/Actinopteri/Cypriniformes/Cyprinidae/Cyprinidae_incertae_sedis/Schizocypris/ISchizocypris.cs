namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis.Schizocypris;

/// <summary>
/// Interface defining characteristics of Schizocypris (genus).
/// </summary>
public interface ISchizocypris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
