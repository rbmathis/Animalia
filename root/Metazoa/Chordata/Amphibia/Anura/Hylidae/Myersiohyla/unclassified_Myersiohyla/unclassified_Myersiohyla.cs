using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Myersiohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Myersiohyla.unclassified_Myersiohyla;

/// <summary>
/// Abstract class for unclassified Myersiohyla (no rank).
/// NCBI TaxId: 2626424
/// </summary>
public abstract class unclassified_Myersiohyla : Myersiohyla, Iunclassified_Myersiohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myersiohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626424;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myersiohyla";
}
