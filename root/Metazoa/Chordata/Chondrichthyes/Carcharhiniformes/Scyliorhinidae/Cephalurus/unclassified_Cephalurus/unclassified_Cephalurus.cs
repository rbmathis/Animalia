using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Cephalurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Cephalurus.unclassified_Cephalurus;

/// <summary>
/// Abstract class for unclassified Cephalurus (no rank).
/// NCBI TaxId: 2630159
/// </summary>
public abstract class unclassified_Cephalurus : Cephalurus, Iunclassified_Cephalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cephalurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630159;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cephalurus";
}
