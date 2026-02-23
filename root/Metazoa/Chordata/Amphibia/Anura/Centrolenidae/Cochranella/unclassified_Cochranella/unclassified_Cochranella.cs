using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Cochranella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Cochranella.unclassified_Cochranella;

/// <summary>
/// Abstract class for unclassified Cochranella (no rank).
/// NCBI TaxId: 2638196
/// </summary>
public abstract class unclassified_Cochranella : Cochranella, Iunclassified_Cochranella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cochranella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638196;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cochranella";
}
