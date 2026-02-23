using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Akysis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Akysis.unclassified_Akysis;

/// <summary>
/// Abstract class for unclassified Akysis (no rank).
/// NCBI TaxId: 2639893
/// </summary>
public abstract class unclassified_Akysis : Akysis, Iunclassified_Akysis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Akysis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Akysis";
}
