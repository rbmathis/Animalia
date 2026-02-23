using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Sphaerodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Sphaerodactylus.unclassified_Sphaerodactylus;

/// <summary>
/// Abstract class for unclassified Sphaerodactylus (no rank).
/// NCBI TaxId: 2620606
/// </summary>
public abstract class unclassified_Sphaerodactylus : Sphaerodactylus, Iunclassified_Sphaerodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphaerodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620606;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphaerodactylus";
}
