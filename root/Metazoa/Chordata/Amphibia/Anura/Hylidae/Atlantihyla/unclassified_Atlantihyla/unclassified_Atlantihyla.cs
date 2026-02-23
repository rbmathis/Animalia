using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Atlantihyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Atlantihyla.unclassified_Atlantihyla;

/// <summary>
/// Abstract class for unclassified Atlantihyla (no rank).
/// NCBI TaxId: 2641359
/// </summary>
public abstract class unclassified_Atlantihyla : Atlantihyla, Iunclassified_Atlantihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atlantihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641359;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atlantihyla";
}
