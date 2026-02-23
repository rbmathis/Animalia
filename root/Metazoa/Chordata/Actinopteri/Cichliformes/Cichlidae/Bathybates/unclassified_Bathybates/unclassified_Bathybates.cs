using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Bathybates;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Bathybates.unclassified_Bathybates;

/// <summary>
/// Abstract class for unclassified Bathybates (no rank).
/// NCBI TaxId: 2649018
/// </summary>
public abstract class unclassified_Bathybates : Bathybates, Iunclassified_Bathybates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathybates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathybates";
}
