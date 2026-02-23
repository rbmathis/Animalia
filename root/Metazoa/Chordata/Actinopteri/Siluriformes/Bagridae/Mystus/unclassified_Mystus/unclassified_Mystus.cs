using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Mystus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Mystus.unclassified_Mystus;

/// <summary>
/// Abstract class for unclassified Mystus (no rank).
/// NCBI TaxId: 2633484
/// </summary>
public abstract class unclassified_Mystus : Mystus, Iunclassified_Mystus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mystus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633484;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mystus";
}
