using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kaloula;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kaloula.unclassified_Kaloula;

/// <summary>
/// Abstract class for unclassified Kaloula (no rank).
/// NCBI TaxId: 2646193
/// </summary>
public abstract class unclassified_Kaloula : Kaloula, Iunclassified_Kaloula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kaloula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646193;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kaloula";
}
