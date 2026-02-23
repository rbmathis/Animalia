using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Rhonciscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Rhonciscus.unclassified_Rhonciscus;

/// <summary>
/// Abstract class for unclassified Rhonciscus (no rank).
/// NCBI TaxId: 2922905
/// </summary>
public abstract class unclassified_Rhonciscus : Rhonciscus, Iunclassified_Rhonciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhonciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2922905;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhonciscus";
}
