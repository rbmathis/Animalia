using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae.Pardalotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae.Pardalotus.unclassified_Pardalotus;

/// <summary>
/// Abstract class for unclassified Pardalotus (no rank).
/// NCBI TaxId: 2641002
/// </summary>
public abstract class unclassified_Pardalotus : Pardalotus, Iunclassified_Pardalotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pardalotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641002;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pardalotus";
}
