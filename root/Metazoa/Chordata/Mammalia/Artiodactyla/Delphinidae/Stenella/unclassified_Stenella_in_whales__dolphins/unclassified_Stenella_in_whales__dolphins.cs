using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Stenella;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Stenella.unclassified_Stenella_in_whales__dolphins;

/// <summary>
/// Abstract class for unclassified Stenella (in: whales & dolphins) (no rank).
/// NCBI TaxId: 2688959
/// </summary>
public abstract class unclassified_Stenella_in_whales__dolphins : Stenella, Iunclassified_Stenella_in_whales__dolphins
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stenella (in: whales & dolphins)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688959;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stenella_in_whales__dolphins";
}
