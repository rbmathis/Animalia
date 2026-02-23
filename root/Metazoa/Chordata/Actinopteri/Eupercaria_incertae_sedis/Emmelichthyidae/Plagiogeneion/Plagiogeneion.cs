using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Plagiogeneion;

/// <summary>
/// Abstract class for Plagiogeneion (genus).
/// NCBI TaxId: 443803
/// </summary>
public abstract class Plagiogeneion : Emmelichthyidae, IPlagiogeneion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plagiogeneion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443803;

    /// <inheritdoc />
    public virtual string GenusName => "Plagiogeneion";

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
