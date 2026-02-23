using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Ebinania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Ebinania.unclassified_Ebinania;

/// <summary>
/// Abstract class for unclassified Ebinania (no rank).
/// NCBI TaxId: 2696548
/// </summary>
public abstract class unclassified_Ebinania : Ebinania, Iunclassified_Ebinania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ebinania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696548;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ebinania";
}
