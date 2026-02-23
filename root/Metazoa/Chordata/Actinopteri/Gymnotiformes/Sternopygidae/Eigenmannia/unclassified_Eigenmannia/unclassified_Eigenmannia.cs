using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Eigenmannia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Eigenmannia.unclassified_Eigenmannia;

/// <summary>
/// Abstract class for unclassified Eigenmannia (no rank).
/// NCBI TaxId: 2684938
/// </summary>
public abstract class unclassified_Eigenmannia : Eigenmannia, Iunclassified_Eigenmannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eigenmannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684938;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eigenmannia";
}
