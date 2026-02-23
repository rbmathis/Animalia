using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Dama;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Dama.unclassified_Dama;

/// <summary>
/// Abstract class for unclassified Dama (no rank).
/// NCBI TaxId: 2644148
/// </summary>
public abstract class unclassified_Dama : Dama, Iunclassified_Dama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644148;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dama";
}
