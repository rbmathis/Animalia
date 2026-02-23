using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus.unclassified_Plecotus;

/// <summary>
/// Abstract class for unclassified Plecotus (no rank).
/// NCBI TaxId: 1032398
/// </summary>
public abstract class unclassified_Plecotus : Plecotus, Iunclassified_Plecotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plecotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1032398;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plecotus";
}
