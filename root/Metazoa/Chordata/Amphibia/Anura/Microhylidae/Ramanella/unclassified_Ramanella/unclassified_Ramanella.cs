using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Ramanella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Ramanella.unclassified_Ramanella;

/// <summary>
/// Abstract class for unclassified Ramanella (no rank).
/// NCBI TaxId: 2677804
/// </summary>
public abstract class unclassified_Ramanella : Ramanella, Iunclassified_Ramanella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ramanella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677804;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ramanella";
}
