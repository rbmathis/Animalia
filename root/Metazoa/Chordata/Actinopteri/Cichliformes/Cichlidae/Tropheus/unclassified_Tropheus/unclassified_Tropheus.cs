using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheus.unclassified_Tropheus;

/// <summary>
/// Abstract class for unclassified Tropheus (no rank).
/// NCBI TaxId: 2622033
/// </summary>
public abstract class unclassified_Tropheus : Tropheus, Iunclassified_Tropheus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tropheus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622033;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tropheus";
}
