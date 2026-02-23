using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Rheohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Rheohyla.unclassified_Rheohyla;

/// <summary>
/// Abstract class for unclassified Rheohyla (no rank).
/// NCBI TaxId: 2663340
/// </summary>
public abstract class unclassified_Rheohyla : Rheohyla, Iunclassified_Rheohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rheohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2663340;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rheohyla";
}
