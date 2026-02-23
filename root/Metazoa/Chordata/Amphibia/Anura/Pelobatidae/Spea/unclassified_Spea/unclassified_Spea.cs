using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Spea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Spea.unclassified_Spea;

/// <summary>
/// Abstract class for unclassified Spea (no rank).
/// NCBI TaxId: 2700118
/// </summary>
public abstract class unclassified_Spea : Spea, Iunclassified_Spea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2700118;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spea";
}
