using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.unclassified_Pyuridae;

/// <summary>
/// Abstract class for unclassified Pyuridae (no rank).
/// NCBI TaxId: 32437
/// </summary>
public abstract class unclassified_Pyuridae : Pyuridae, Iunclassified_Pyuridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyuridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32437;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyuridae";
}
