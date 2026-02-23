using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycenchelys.unclassified_Lycenchelys;

/// <summary>
/// Abstract class for unclassified Lycenchelys (no rank).
/// NCBI TaxId: 2630833
/// </summary>
public abstract class unclassified_Lycenchelys : Lycenchelys, Iunclassified_Lycenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630833;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycenchelys";
}
