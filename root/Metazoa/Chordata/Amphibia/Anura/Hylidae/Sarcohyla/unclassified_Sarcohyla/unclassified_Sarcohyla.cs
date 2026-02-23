using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sarcohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sarcohyla.unclassified_Sarcohyla;

/// <summary>
/// Abstract class for unclassified Sarcohyla (no rank).
/// NCBI TaxId: 2629386
/// </summary>
public abstract class unclassified_Sarcohyla : Sarcohyla, Iunclassified_Sarcohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sarcohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629386;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sarcohyla";
}
