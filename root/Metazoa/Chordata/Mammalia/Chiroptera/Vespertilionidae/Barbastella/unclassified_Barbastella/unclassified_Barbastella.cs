using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Barbastella;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Barbastella.unclassified_Barbastella;

/// <summary>
/// Abstract class for unclassified Barbastella (no rank).
/// NCBI TaxId: 2677011
/// </summary>
public abstract class unclassified_Barbastella : Barbastella, Iunclassified_Barbastella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barbastella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677011;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barbastella";
}
