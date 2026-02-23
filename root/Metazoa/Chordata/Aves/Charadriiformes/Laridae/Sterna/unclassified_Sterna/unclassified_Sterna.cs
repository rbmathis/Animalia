using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sterna;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sterna.unclassified_Sterna;

/// <summary>
/// Abstract class for unclassified Sterna (no rank).
/// NCBI TaxId: 2640654
/// </summary>
public abstract class unclassified_Sterna : Sterna, Iunclassified_Sterna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sterna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640654;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sterna";
}
