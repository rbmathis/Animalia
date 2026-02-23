using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudotropheus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudotropheus.unclassified_Pseudotropheus;

/// <summary>
/// Abstract class for unclassified Pseudotropheus (no rank).
/// NCBI TaxId: 2640765
/// </summary>
public abstract class unclassified_Pseudotropheus : Pseudotropheus, Iunclassified_Pseudotropheus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudotropheus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudotropheus";
}
