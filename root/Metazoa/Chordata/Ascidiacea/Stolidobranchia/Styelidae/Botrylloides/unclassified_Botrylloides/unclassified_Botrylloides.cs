using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botrylloides;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botrylloides.unclassified_Botrylloides;

/// <summary>
/// Abstract class for unclassified Botrylloides (no rank).
/// NCBI TaxId: 2619109
/// </summary>
public abstract class unclassified_Botrylloides : Botrylloides, Iunclassified_Botrylloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Botrylloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619109;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Botrylloides";
}
