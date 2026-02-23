using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Microcosmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Microcosmus.unclassified_Microcosmus;

/// <summary>
/// Abstract class for unclassified Microcosmus (no rank).
/// NCBI TaxId: 2619485
/// </summary>
public abstract class unclassified_Microcosmus : Microcosmus, Iunclassified_Microcosmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microcosmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619485;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microcosmus";
}
