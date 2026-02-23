using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Davidijordania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Davidijordania.unclassified_Davidijordania;

/// <summary>
/// Abstract class for unclassified Davidijordania (no rank).
/// NCBI TaxId: 2623969
/// </summary>
public abstract class unclassified_Davidijordania : Davidijordania, Iunclassified_Davidijordania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Davidijordania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623969;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Davidijordania";
}
