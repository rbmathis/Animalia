using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona.unclassified_Ciona;

/// <summary>
/// Abstract class for unclassified Ciona (no rank).
/// NCBI TaxId: 2619915
/// </summary>
public abstract class unclassified_Ciona : Ciona, Iunclassified_Ciona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ciona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619915;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ciona";
}
