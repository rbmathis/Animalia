using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae.Ochotona;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae.Ochotona.unclassified_Ochotona;

/// <summary>
/// Abstract class for unclassified Ochotona (no rank).
/// NCBI TaxId: 2609447
/// </summary>
public abstract class unclassified_Ochotona : Ochotona, Iunclassified_Ochotona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ochotona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609447;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ochotona";
}
