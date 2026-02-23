using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx.unclassified_Lynx;

/// <summary>
/// Abstract class for unclassified Lynx (no rank).
/// NCBI TaxId: 3435966
/// </summary>
public abstract class unclassified_Lynx : Lynx, Iunclassified_Lynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3435966;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lynx";
}
