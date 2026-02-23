using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Eudistoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Eudistoma.unclassified_Eudistoma;

/// <summary>
/// Abstract class for unclassified Eudistoma (no rank).
/// NCBI TaxId: 2622331
/// </summary>
public abstract class unclassified_Eudistoma : Eudistoma, Iunclassified_Eudistoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eudistoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622331;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eudistoma";
}
