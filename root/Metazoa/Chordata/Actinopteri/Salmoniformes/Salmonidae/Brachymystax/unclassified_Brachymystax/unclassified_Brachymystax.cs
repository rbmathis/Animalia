using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Brachymystax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Brachymystax.unclassified_Brachymystax;

/// <summary>
/// Abstract class for unclassified Brachymystax (no rank).
/// NCBI TaxId: 2936732
/// </summary>
public abstract class unclassified_Brachymystax : Brachymystax, Iunclassified_Brachymystax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachymystax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2936732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachymystax";
}
