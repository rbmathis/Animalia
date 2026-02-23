using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Conger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Conger.unclassified_Conger;

/// <summary>
/// Abstract class for unclassified Conger (no rank).
/// NCBI TaxId: 2629996
/// </summary>
public abstract class unclassified_Conger : Conger, Iunclassified_Conger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Conger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629996;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Conger";
}
