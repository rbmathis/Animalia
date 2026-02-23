using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrotilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrotilapia.unclassified_Petrotilapia;

/// <summary>
/// Abstract class for unclassified Petrotilapia (no rank).
/// NCBI TaxId: 2640446
/// </summary>
public abstract class unclassified_Petrotilapia : Petrotilapia, Iunclassified_Petrotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petrotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640446;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petrotilapia";
}
