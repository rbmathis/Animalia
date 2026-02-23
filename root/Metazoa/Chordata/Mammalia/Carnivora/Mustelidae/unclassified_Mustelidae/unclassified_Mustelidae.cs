using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.unclassified_Mustelidae;

/// <summary>
/// Abstract class for unclassified Mustelidae (no rank).
/// NCBI TaxId: 1967457
/// </summary>
public abstract class unclassified_Mustelidae : Mustelidae, Iunclassified_Mustelidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mustelidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1967457;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mustelidae";
}
