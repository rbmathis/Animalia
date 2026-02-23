using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Nyctalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Nyctalus.unclassified_Nyctalus;

/// <summary>
/// Abstract class for unclassified Nyctalus (no rank).
/// NCBI TaxId: 2618540
/// </summary>
public abstract class unclassified_Nyctalus : Nyctalus, Iunclassified_Nyctalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618540;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctalus";
}
