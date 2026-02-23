using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Haemulon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Haemulon.unclassified_Haemulon;

/// <summary>
/// Abstract class for unclassified Haemulon (no rank).
/// NCBI TaxId: 2622080
/// </summary>
public abstract class unclassified_Haemulon : Haemulon, Iunclassified_Haemulon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Haemulon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622080;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Haemulon";
}
