using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllomedusa;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllomedusa.unclassified_Phyllomedusa;

/// <summary>
/// Abstract class for unclassified Phyllomedusa (no rank).
/// NCBI TaxId: 2635893
/// </summary>
public abstract class unclassified_Phyllomedusa : Phyllomedusa, Iunclassified_Phyllomedusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllomedusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllomedusa";
}
