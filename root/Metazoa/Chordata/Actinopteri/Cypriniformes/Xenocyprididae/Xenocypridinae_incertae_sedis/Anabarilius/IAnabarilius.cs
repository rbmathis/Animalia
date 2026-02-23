namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_incertae_sedis.Anabarilius;

/// <summary>
/// Interface defining characteristics of Anabarilius (genus).
/// </summary>
public interface IAnabarilius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
