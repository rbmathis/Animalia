using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Adontosternarchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Adontosternarchus.unclassified_Adontosternarchus;

/// <summary>
/// Abstract class for unclassified Adontosternarchus (no rank).
/// NCBI TaxId: 2676930
/// </summary>
public abstract class unclassified_Adontosternarchus : Adontosternarchus, Iunclassified_Adontosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Adontosternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676930;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Adontosternarchus";
}
