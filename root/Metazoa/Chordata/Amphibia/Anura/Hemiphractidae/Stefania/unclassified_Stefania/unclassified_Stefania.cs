using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Stefania;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Stefania.unclassified_Stefania;

/// <summary>
/// Abstract class for unclassified Stefania (no rank).
/// NCBI TaxId: 2627807
/// </summary>
public abstract class unclassified_Stefania : Stefania, Iunclassified_Stefania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stefania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627807;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stefania";
}
