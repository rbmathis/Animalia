using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Saurenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Saurenchelys.unclassified_Saurenchelys;

/// <summary>
/// Abstract class for unclassified Saurenchelys (no rank).
/// NCBI TaxId: 2647229
/// </summary>
public abstract class unclassified_Saurenchelys : Saurenchelys, Iunclassified_Saurenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saurenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647229;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saurenchelys";
}
