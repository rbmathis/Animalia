namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.Diretmus;

/// <summary>
/// Interface defining characteristics of Diretmus (genus).
/// </summary>
public interface IDiretmus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
