using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Chaenopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Chaenopsis.unclassified_Chaenopsis;

/// <summary>
/// Abstract class for unclassified Chaenopsis (no rank).
/// NCBI TaxId: 2684981
/// </summary>
public abstract class unclassified_Chaenopsis : Chaenopsis, Iunclassified_Chaenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684981;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaenopsis";
}
