using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bokermannohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bokermannohyla.unclassified_Bokermannohyla;

/// <summary>
/// Abstract class for unclassified Bokermannohyla (no rank).
/// NCBI TaxId: 2621556
/// </summary>
public abstract class unclassified_Bokermannohyla : Bokermannohyla, Iunclassified_Bokermannohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bokermannohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621556;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bokermannohyla";
}
