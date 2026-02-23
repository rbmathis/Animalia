using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella.unclassified_Rhinella;

/// <summary>
/// Abstract class for unclassified Rhinella (no rank).
/// NCBI TaxId: 2622869
/// </summary>
public abstract class unclassified_Rhinella : Rhinella, Iunclassified_Rhinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622869;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinella";
}
