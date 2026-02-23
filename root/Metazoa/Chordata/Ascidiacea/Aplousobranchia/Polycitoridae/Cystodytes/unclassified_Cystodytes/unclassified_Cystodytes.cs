using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Cystodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Cystodytes.unclassified_Cystodytes;

/// <summary>
/// Abstract class for unclassified Cystodytes (no rank).
/// NCBI TaxId: 2633143
/// </summary>
public abstract class unclassified_Cystodytes : Cystodytes, Iunclassified_Cystodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cystodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633143;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cystodytes";
}
