using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla.unclassified_Hyla;

/// <summary>
/// Abstract class for unclassified Hyla (no rank).
/// NCBI TaxId: 2638984
/// </summary>
public abstract class unclassified_Hyla : Hyla, Iunclassified_Hyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638984;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyla";
}
