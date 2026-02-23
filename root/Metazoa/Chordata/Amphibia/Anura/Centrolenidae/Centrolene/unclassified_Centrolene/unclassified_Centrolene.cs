using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolene;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolene.unclassified_Centrolene;

/// <summary>
/// Abstract class for unclassified Centrolene (no rank).
/// NCBI TaxId: 2644495
/// </summary>
public abstract class unclassified_Centrolene : Centrolene, Iunclassified_Centrolene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centrolene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644495;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centrolene";
}
