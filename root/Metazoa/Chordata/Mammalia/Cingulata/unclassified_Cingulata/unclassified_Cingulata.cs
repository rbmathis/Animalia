using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.unclassified_Cingulata;

/// <summary>
/// Abstract class for unclassified Cingulata (no rank).
/// NCBI TaxId: 948956
/// </summary>
public abstract class unclassified_Cingulata : Cingulata, Iunclassified_Cingulata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cingulata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948956;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cingulata";
}
