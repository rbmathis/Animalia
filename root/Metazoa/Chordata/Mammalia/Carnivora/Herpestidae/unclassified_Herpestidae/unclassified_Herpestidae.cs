using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.unclassified_Herpestidae;

/// <summary>
/// Abstract class for unclassified Herpestidae (no rank).
/// NCBI TaxId: 373388
/// </summary>
public abstract class unclassified_Herpestidae : Herpestidae, Iunclassified_Herpestidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Herpestidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 373388;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Herpestidae";
}
