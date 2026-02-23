using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Polycitor;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Polycitor.unclassified_Polycitor;

/// <summary>
/// Abstract class for unclassified Polycitor (no rank).
/// NCBI TaxId: 2795857
/// </summary>
public abstract class unclassified_Polycitor : Polycitor, Iunclassified_Polycitor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polycitor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2795857;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polycitor";
}
