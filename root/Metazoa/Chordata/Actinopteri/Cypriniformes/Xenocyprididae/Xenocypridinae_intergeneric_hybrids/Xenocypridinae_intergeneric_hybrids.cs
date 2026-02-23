using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Xenocypridinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2762079
/// </summary>
public abstract class Xenocypridinae_intergeneric_hybrids : Xenocyprididae, IXenocypridinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenocypridinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2762079;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Xenocypridinae_intergeneric_hybrids";
}
