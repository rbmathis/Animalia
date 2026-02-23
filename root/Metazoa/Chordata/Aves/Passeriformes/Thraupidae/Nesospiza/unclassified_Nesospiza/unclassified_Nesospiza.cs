using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Nesospiza;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Nesospiza.unclassified_Nesospiza;

/// <summary>
/// Abstract class for unclassified Nesospiza (no rank).
/// NCBI TaxId: 2646964
/// </summary>
public abstract class unclassified_Nesospiza : Nesospiza, Iunclassified_Nesospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nesospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nesospiza";
}
