using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Micryletta;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Micryletta.unclassified_Micryletta;

/// <summary>
/// Abstract class for unclassified Micryletta (no rank).
/// NCBI TaxId: 2609364
/// </summary>
public abstract class unclassified_Micryletta : Micryletta, Iunclassified_Micryletta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micryletta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609364;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micryletta";
}
