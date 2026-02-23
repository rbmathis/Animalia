using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Globicephala;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Globicephala.unclassified_Globicephala;

/// <summary>
/// Abstract class for unclassified Globicephala (no rank).
/// NCBI TaxId: 2637209
/// </summary>
public abstract class unclassified_Globicephala : Globicephala, Iunclassified_Globicephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Globicephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637209;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Globicephala";
}
