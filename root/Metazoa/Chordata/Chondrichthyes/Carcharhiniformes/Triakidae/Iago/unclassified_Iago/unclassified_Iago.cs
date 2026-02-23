using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Iago;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Iago.unclassified_Iago;

/// <summary>
/// Abstract class for unclassified Iago (no rank).
/// NCBI TaxId: 2603155
/// </summary>
public abstract class unclassified_Iago : Iago, Iunclassified_Iago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Iago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2603155;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Iago";
}
