using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Pristigenys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Pristigenys.unclassified_Pristigenys;

/// <summary>
/// Abstract class for unclassified Pristigenys (no rank).
/// NCBI TaxId: 2619500
/// </summary>
public abstract class unclassified_Pristigenys : Pristigenys, Iunclassified_Pristigenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristigenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619500;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristigenys";
}
