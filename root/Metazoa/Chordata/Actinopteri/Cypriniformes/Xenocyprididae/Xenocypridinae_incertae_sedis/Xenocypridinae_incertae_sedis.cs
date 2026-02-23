using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_incertae_sedis;

/// <summary>
/// Abstract class for Xenocypridinae incertae sedis (no rank).
/// NCBI TaxId: 2743748
/// </summary>
public abstract class Xenocypridinae_incertae_sedis : Xenocyprididae, IXenocypridinae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenocypridinae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Xenocypridinae_incertae_sedis";
}
