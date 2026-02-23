using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Pyura;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Pyura.unclassified_Pyura;

/// <summary>
/// Abstract class for unclassified Pyura (no rank).
/// NCBI TaxId: 2621774
/// </summary>
public abstract class unclassified_Pyura : Pyura, Iunclassified_Pyura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621774;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyura";
}
