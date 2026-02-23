using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.unclassified_Salmoninae;

/// <summary>
/// Abstract class for unclassified Salmoninae (no rank).
/// NCBI TaxId: 2476907
/// </summary>
public abstract class unclassified_Salmoninae : Salmonidae, Iunclassified_Salmoninae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salmoninae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2476907;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salmoninae";
}
