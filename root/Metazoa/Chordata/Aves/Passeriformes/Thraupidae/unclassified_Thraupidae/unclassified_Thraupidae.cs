using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.unclassified_Thraupidae;

/// <summary>
/// Abstract class for unclassified Thraupidae (no rank).
/// NCBI TaxId: 2867487
/// </summary>
public abstract class unclassified_Thraupidae : Thraupidae, Iunclassified_Thraupidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thraupidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2867487;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thraupidae";
}
