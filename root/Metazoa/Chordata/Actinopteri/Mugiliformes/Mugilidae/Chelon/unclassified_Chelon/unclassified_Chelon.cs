using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Chelon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Chelon.unclassified_Chelon;

/// <summary>
/// Abstract class for unclassified Chelon (no rank).
/// NCBI TaxId: 2685167
/// </summary>
public abstract class unclassified_Chelon : Chelon, Iunclassified_Chelon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chelon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685167;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chelon";
}
