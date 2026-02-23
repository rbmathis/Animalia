using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae.Beryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae.Beryx.unclassified_Beryx;

/// <summary>
/// Abstract class for unclassified Beryx (no rank).
/// NCBI TaxId: 2648688
/// </summary>
public abstract class unclassified_Beryx : Beryx, Iunclassified_Beryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Beryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648688;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Beryx";
}
