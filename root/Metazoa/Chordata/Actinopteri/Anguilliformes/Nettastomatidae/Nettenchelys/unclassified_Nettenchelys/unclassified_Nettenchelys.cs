using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Nettenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Nettenchelys.unclassified_Nettenchelys;

/// <summary>
/// Abstract class for unclassified Nettenchelys (no rank).
/// NCBI TaxId: 3415245
/// </summary>
public abstract class unclassified_Nettenchelys : Nettenchelys, Iunclassified_Nettenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nettenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3415245;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nettenchelys";
}
