using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.unclassified_Ascidiidae;

/// <summary>
/// Abstract class for unclassified Ascidiidae (no rank).
/// NCBI TaxId: 3061328
/// </summary>
public abstract class unclassified_Ascidiidae : Ascidiidae, Iunclassified_Ascidiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ascidiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3061328;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ascidiidae";
}
