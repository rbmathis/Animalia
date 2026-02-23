using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Plectorhinchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Plectorhinchus.unclassified_Plectorhinchus;

/// <summary>
/// Abstract class for unclassified Plectorhinchus (no rank).
/// NCBI TaxId: 2618401
/// </summary>
public abstract class unclassified_Plectorhinchus : Plectorhinchus, Iunclassified_Plectorhinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plectorhinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618401;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plectorhinchus";
}
