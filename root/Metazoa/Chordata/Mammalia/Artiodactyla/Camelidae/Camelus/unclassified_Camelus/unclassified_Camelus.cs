using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus.unclassified_Camelus;

/// <summary>
/// Abstract class for unclassified Camelus (no rank).
/// NCBI TaxId: 2649867
/// </summary>
public abstract class unclassified_Camelus : Camelus, Iunclassified_Camelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Camelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649867;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Camelus";
}
