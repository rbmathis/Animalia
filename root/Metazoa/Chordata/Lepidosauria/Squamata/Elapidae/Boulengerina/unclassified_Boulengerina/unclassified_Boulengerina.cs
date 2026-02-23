using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Boulengerina;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Boulengerina.unclassified_Boulengerina;

/// <summary>
/// Abstract class for unclassified Boulengerina (no rank).
/// NCBI TaxId: 2648978
/// </summary>
public abstract class unclassified_Boulengerina : Boulengerina, Iunclassified_Boulengerina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boulengerina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648978;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boulengerina";
}
