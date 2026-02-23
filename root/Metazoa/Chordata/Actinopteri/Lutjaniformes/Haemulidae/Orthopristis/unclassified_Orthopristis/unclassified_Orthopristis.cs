using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Orthopristis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Orthopristis.unclassified_Orthopristis;

/// <summary>
/// Abstract class for unclassified Orthopristis (no rank).
/// NCBI TaxId: 2638255
/// </summary>
public abstract class unclassified_Orthopristis : Orthopristis, Iunclassified_Orthopristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Orthopristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Orthopristis";
}
