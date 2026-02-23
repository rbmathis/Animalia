using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Abstract class for unclassified Anura (no rank).
/// NCBI TaxId: 43511
/// </summary>
public abstract class unclassified_Anura : Anura, Iunclassified_Anura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43511;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anura";
}
