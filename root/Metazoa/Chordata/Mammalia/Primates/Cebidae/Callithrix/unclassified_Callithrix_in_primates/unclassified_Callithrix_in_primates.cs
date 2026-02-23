using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callithrix;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callithrix.unclassified_Callithrix_in_primates;

/// <summary>
/// Abstract class for unclassified Callithrix (in: primates) (no rank).
/// NCBI TaxId: 3406878
/// </summary>
public abstract class unclassified_Callithrix_in_primates : Callithrix, Iunclassified_Callithrix_in_primates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callithrix (in: primates)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406878;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callithrix_in_primates";
}
