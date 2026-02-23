using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.unclassified_Didemnidae;

/// <summary>
/// Abstract class for unclassified Didemnidae (no rank).
/// NCBI TaxId: 2501421
/// </summary>
public abstract class unclassified_Didemnidae : Didemnidae, Iunclassified_Didemnidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Didemnidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2501421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Didemnidae";
}
