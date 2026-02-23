using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Hemibagrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Hemibagrus.unclassified_Hemibagrus;

/// <summary>
/// Abstract class for unclassified Hemibagrus (no rank).
/// NCBI TaxId: 2635509
/// </summary>
public abstract class unclassified_Hemibagrus : Hemibagrus, Iunclassified_Hemibagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemibagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635509;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemibagrus";
}
