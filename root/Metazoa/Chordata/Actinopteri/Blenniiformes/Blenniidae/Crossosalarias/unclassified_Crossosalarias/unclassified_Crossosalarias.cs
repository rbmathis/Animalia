using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Crossosalarias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Crossosalarias.unclassified_Crossosalarias;

/// <summary>
/// Abstract class for unclassified Crossosalarias (no rank).
/// NCBI TaxId: 3446938
/// </summary>
public abstract class unclassified_Crossosalarias : Crossosalarias, Iunclassified_Crossosalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crossosalarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446938;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crossosalarias";
}
