using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Acestridium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Acestridium.unclassified_Acestridium;

/// <summary>
/// Abstract class for unclassified Acestridium (no rank).
/// NCBI TaxId: 2638012
/// </summary>
public abstract class unclassified_Acestridium : Acestridium, Iunclassified_Acestridium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acestridium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638012;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acestridium";
}
