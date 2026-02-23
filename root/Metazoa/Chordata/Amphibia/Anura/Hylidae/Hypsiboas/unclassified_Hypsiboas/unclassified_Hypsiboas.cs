using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hypsiboas;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hypsiboas.unclassified_Hypsiboas;

/// <summary>
/// Abstract class for unclassified Hypsiboas (no rank).
/// NCBI TaxId: 2632122
/// </summary>
public abstract class unclassified_Hypsiboas : Hypsiboas, Iunclassified_Hypsiboas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypsiboas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632122;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypsiboas";
}
