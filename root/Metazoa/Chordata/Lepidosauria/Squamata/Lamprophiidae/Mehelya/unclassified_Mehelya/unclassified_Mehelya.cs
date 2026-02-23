using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Mehelya;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Mehelya.unclassified_Mehelya;

/// <summary>
/// Abstract class for unclassified Mehelya (no rank).
/// NCBI TaxId: 3467881
/// </summary>
public abstract class unclassified_Mehelya : Mehelya, Iunclassified_Mehelya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mehelya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mehelya";
}
