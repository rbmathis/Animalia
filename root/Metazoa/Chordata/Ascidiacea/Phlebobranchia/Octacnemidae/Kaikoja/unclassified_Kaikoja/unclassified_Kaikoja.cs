using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Kaikoja;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Kaikoja.unclassified_Kaikoja;

/// <summary>
/// Abstract class for unclassified Kaikoja (no rank).
/// NCBI TaxId: 3475077
/// </summary>
public abstract class unclassified_Kaikoja : Kaikoja, Iunclassified_Kaikoja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kaikoja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3475077;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kaikoja";
}
