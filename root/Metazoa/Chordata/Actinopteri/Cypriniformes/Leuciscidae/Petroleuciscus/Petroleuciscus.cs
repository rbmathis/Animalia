using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Petroleuciscus;

/// <summary>
/// Abstract class for Petroleuciscus (genus).
/// NCBI TaxId: 643422
/// </summary>
public abstract class Petroleuciscus : Leuciscidae, IPetroleuciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petroleuciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643422;

    /// <inheritdoc />
    public virtual string GenusName => "Petroleuciscus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
