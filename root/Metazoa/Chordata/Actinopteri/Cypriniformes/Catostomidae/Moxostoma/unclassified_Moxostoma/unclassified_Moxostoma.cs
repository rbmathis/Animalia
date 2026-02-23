using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Moxostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Moxostoma.unclassified_Moxostoma;

/// <summary>
/// Abstract class for unclassified Moxostoma (no rank).
/// NCBI TaxId: 2619154
/// </summary>
public abstract class unclassified_Moxostoma : Moxostoma, Iunclassified_Moxostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moxostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619154;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moxostoma";
}
