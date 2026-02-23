namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae.Umbra;

/// <summary>
/// Interface defining characteristics of Umbra (genus).
/// </summary>
public interface IUmbra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
