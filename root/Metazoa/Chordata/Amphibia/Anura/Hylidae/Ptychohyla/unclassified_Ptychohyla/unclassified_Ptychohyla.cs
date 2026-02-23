using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ptychohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ptychohyla.unclassified_Ptychohyla;

/// <summary>
/// Abstract class for unclassified Ptychohyla (no rank).
/// NCBI TaxId: 2643490
/// </summary>
public abstract class unclassified_Ptychohyla : Ptychohyla, Iunclassified_Ptychohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ptychohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643490;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ptychohyla";
}
