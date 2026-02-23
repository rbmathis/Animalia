using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paratilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paratilapia.unclassified_Paratilapia;

/// <summary>
/// Abstract class for unclassified Paratilapia (no rank).
/// NCBI TaxId: 2622333
/// </summary>
public abstract class unclassified_Paratilapia : Paratilapia, Iunclassified_Paratilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paratilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622333;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paratilapia";
}
