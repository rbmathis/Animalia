using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tragelaphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tragelaphus.unclassified_Tragelaphus;

/// <summary>
/// Abstract class for unclassified Tragelaphus (no rank).
/// NCBI TaxId: 2641943
/// </summary>
public abstract class unclassified_Tragelaphus : Tragelaphus, Iunclassified_Tragelaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tragelaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641943;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tragelaphus";
}
