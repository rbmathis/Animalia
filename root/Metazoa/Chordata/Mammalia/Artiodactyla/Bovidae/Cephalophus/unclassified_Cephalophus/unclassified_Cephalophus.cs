using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophus.unclassified_Cephalophus;

/// <summary>
/// Abstract class for unclassified Cephalophus (no rank).
/// NCBI TaxId: 2623018
/// </summary>
public abstract class unclassified_Cephalophus : Cephalophus, Iunclassified_Cephalophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cephalophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cephalophus";
}
