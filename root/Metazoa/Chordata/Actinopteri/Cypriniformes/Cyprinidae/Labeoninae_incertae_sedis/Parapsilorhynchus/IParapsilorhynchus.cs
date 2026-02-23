namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Parapsilorhynchus;

/// <summary>
/// Interface defining characteristics of Parapsilorhynchus (genus).
/// </summary>
public interface IParapsilorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
