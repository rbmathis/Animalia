using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Herdmania;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Herdmania.unclassified_Herdmania_in_tunicates;

/// <summary>
/// Abstract class for unclassified Herdmania (in: tunicates) (no rank).
/// NCBI TaxId: 2688546
/// </summary>
public abstract class unclassified_Herdmania_in_tunicates : Herdmania, Iunclassified_Herdmania_in_tunicates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Herdmania (in: tunicates)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688546;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Herdmania_in_tunicates";
}
