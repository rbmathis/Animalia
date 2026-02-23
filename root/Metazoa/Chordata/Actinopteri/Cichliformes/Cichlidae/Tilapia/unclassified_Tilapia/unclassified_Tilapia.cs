using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia.unclassified_Tilapia;

/// <summary>
/// Abstract class for unclassified Tilapia (no rank).
/// NCBI TaxId: 2637127
/// </summary>
public abstract class unclassified_Tilapia : Tilapia, Iunclassified_Tilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637127;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tilapia";
}
