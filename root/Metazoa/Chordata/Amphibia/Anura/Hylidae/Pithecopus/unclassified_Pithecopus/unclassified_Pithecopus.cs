using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pithecopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pithecopus.unclassified_Pithecopus;

/// <summary>
/// Abstract class for unclassified Pithecopus (no rank).
/// NCBI TaxId: 2781294
/// </summary>
public abstract class unclassified_Pithecopus : Pithecopus, Iunclassified_Pithecopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pithecopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2781294;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pithecopus";
}
