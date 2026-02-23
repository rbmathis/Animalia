using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Onychostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Onychostoma.unclassified_Onychostoma;

/// <summary>
/// Abstract class for unclassified Onychostoma (no rank).
/// NCBI TaxId: 2618463
/// </summary>
public abstract class unclassified_Onychostoma : Onychostoma, Iunclassified_Onychostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Onychostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618463;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Onychostoma";
}
