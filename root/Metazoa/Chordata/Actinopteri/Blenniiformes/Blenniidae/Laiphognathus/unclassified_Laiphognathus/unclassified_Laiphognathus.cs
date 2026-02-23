using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Laiphognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Laiphognathus.unclassified_Laiphognathus;

/// <summary>
/// Abstract class for unclassified Laiphognathus (no rank).
/// NCBI TaxId: 3444655
/// </summary>
public abstract class unclassified_Laiphognathus : Laiphognathus, Iunclassified_Laiphognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laiphognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444655;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laiphognathus";
}
