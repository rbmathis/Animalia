using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.unclassified_Hylidae;

/// <summary>
/// Abstract class for unclassified Hylidae (no rank).
/// NCBI TaxId: 343243
/// </summary>
public abstract class unclassified_Hylidae : Hylidae, Iunclassified_Hylidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hylidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 343243;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hylidae";
}
