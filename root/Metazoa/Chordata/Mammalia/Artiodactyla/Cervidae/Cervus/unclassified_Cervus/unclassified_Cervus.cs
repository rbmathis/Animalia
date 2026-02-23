using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus.unclassified_Cervus;

/// <summary>
/// Abstract class for unclassified Cervus (no rank).
/// NCBI TaxId: 2649582
/// </summary>
public abstract class unclassified_Cervus : Cervus, Iunclassified_Cervus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cervus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649582;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cervus";
}
