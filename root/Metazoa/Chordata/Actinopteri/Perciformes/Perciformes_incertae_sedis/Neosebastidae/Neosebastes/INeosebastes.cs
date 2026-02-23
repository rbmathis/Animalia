namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Neosebastidae.Neosebastes;

/// <summary>
/// Interface defining characteristics of Neosebastes (genus).
/// </summary>
public interface INeosebastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
