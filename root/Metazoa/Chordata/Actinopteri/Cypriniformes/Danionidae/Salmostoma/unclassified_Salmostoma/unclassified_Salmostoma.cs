using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Salmostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Salmostoma.unclassified_Salmostoma;

/// <summary>
/// Abstract class for unclassified Salmostoma (no rank).
/// NCBI TaxId: 2644676
/// </summary>
public abstract class unclassified_Salmostoma : Salmostoma, Iunclassified_Salmostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salmostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644676;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salmostoma";
}
