using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Bostrichobranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Bostrichobranchus.unclassified_Bostrichobranchus;

/// <summary>
/// Abstract class for unclassified Bostrichobranchus (no rank).
/// NCBI TaxId: 2986866
/// </summary>
public abstract class unclassified_Bostrichobranchus : Bostrichobranchus, Iunclassified_Bostrichobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bostrichobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986866;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bostrichobranchus";
}
