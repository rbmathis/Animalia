using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Afrixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Afrixalus.unclassified_Afrixalus;

/// <summary>
/// Abstract class for unclassified Afrixalus (no rank).
/// NCBI TaxId: 2640890
/// </summary>
public abstract class unclassified_Afrixalus : Afrixalus, Iunclassified_Afrixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Afrixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640890;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Afrixalus";
}
