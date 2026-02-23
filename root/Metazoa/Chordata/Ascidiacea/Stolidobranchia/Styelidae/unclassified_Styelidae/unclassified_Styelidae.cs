using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.unclassified_Styelidae;

/// <summary>
/// Abstract class for unclassified Styelidae (no rank).
/// NCBI TaxId: 1440614
/// </summary>
public abstract class unclassified_Styelidae : Styelidae, Iunclassified_Styelidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Styelidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1440614;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Styelidae";
}
