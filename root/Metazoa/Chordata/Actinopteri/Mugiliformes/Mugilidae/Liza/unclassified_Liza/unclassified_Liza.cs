using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Liza;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Liza.unclassified_Liza;

/// <summary>
/// Abstract class for unclassified Liza (no rank).
/// NCBI TaxId: 2643938
/// </summary>
public abstract class unclassified_Liza : Liza, Iunclassified_Liza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643938;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liza";
}
