using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Atopophrynus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Atopophrynus.unclassified_Atopophrynus;

/// <summary>
/// Abstract class for unclassified Atopophrynus (no rank).
/// NCBI TaxId: 2793418
/// </summary>
public abstract class unclassified_Atopophrynus : Atopophrynus, Iunclassified_Atopophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atopophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2793418;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atopophrynus";
}
