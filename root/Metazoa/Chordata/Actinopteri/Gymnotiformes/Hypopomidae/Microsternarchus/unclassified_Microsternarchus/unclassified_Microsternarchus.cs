using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Microsternarchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Microsternarchus.unclassified_Microsternarchus;

/// <summary>
/// Abstract class for unclassified Microsternarchus (no rank).
/// NCBI TaxId: 2633602
/// </summary>
public abstract class unclassified_Microsternarchus : Microsternarchus, Iunclassified_Microsternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microsternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633602;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microsternarchus";
}
