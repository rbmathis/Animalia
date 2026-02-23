using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Colocongridae.Coloconger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Colocongridae.Coloconger.unclassified_Coloconger;

/// <summary>
/// Abstract class for unclassified Coloconger (no rank).
/// NCBI TaxId: 2619367
/// </summary>
public abstract class unclassified_Coloconger : Coloconger, Iunclassified_Coloconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coloconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619367;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coloconger";
}
