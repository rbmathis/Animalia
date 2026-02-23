using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Jaydia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Jaydia.unclassified_Jaydia;

/// <summary>
/// Abstract class for unclassified Jaydia (no rank).
/// NCBI TaxId: 2628073
/// </summary>
public abstract class unclassified_Jaydia : Jaydia, Iunclassified_Jaydia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Jaydia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628073;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Jaydia";
}
