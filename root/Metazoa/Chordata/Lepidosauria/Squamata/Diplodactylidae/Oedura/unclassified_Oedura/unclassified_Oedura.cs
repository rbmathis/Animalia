using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Oedura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Oedura.unclassified_Oedura;

/// <summary>
/// Abstract class for unclassified Oedura (no rank).
/// NCBI TaxId: 2640424
/// </summary>
public abstract class unclassified_Oedura : Oedura, Iunclassified_Oedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640424;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oedura";
}
