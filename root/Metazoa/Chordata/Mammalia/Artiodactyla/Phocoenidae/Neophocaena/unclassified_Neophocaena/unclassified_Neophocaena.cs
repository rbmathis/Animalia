using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Neophocaena;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Neophocaena.unclassified_Neophocaena;

/// <summary>
/// Abstract class for unclassified Neophocaena (no rank).
/// NCBI TaxId: 3029581
/// </summary>
public abstract class unclassified_Neophocaena : Neophocaena, Iunclassified_Neophocaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neophocaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3029581;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neophocaena";
}
