using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Cnephaeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Cnephaeus.unclassified_Cnephaeus;

/// <summary>
/// Abstract class for unclassified Cnephaeus (no rank).
/// NCBI TaxId: 3411095
/// </summary>
public abstract class unclassified_Cnephaeus : Cnephaeus, Iunclassified_Cnephaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cnephaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3411095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cnephaeus";
}
