using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Holohalaelurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Holohalaelurus.unclassified_Holohalaelurus;

/// <summary>
/// Abstract class for unclassified Holohalaelurus (no rank).
/// NCBI TaxId: 2643816
/// </summary>
public abstract class unclassified_Holohalaelurus : Holohalaelurus, Iunclassified_Holohalaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Holohalaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643816;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Holohalaelurus";
}
