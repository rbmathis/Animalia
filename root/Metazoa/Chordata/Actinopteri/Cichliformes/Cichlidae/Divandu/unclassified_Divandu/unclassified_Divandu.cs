using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Divandu;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Divandu.unclassified_Divandu;

/// <summary>
/// Abstract class for unclassified Divandu (no rank).
/// NCBI TaxId: 2636713
/// </summary>
public abstract class unclassified_Divandu : Divandu, Iunclassified_Divandu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Divandu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636713;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Divandu";
}
