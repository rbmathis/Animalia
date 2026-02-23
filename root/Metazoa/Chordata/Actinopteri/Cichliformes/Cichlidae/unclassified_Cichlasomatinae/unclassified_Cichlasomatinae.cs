using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.unclassified_Cichlasomatinae;

/// <summary>
/// Abstract class for unclassified Cichlasomatinae (no rank).
/// NCBI TaxId: 1158452
/// </summary>
public abstract class unclassified_Cichlasomatinae : Cichlidae, Iunclassified_Cichlasomatinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cichlasomatinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1158452;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cichlasomatinae";
}
