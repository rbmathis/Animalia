using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Umbrina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Umbrina.unclassified_Umbrina;

/// <summary>
/// Abstract class for unclassified Umbrina (no rank).
/// NCBI TaxId: 2806158
/// </summary>
public abstract class unclassified_Umbrina : Umbrina, Iunclassified_Umbrina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Umbrina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2806158;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Umbrina";
}
