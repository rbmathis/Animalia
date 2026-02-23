using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ophthalmotilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ophthalmotilapia.unclassified_Ophthalmotilapia;

/// <summary>
/// Abstract class for unclassified Ophthalmotilapia (no rank).
/// NCBI TaxId: 2641167
/// </summary>
public abstract class unclassified_Ophthalmotilapia : Ophthalmotilapia, Iunclassified_Ophthalmotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophthalmotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641167;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophthalmotilapia";
}
