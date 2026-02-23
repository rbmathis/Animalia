using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Sceloporus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Sceloporus.unclassified_Sceloporus;

/// <summary>
/// Abstract class for unclassified Sceloporus (no rank).
/// NCBI TaxId: 2636354
/// </summary>
public abstract class unclassified_Sceloporus : Sceloporus, Iunclassified_Sceloporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sceloporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636354;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sceloporus";
}
