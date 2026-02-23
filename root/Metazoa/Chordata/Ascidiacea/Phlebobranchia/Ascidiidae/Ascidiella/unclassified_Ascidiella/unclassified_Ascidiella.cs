using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidiella;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidiella.unclassified_Ascidiella;

/// <summary>
/// Abstract class for unclassified Ascidiella (no rank).
/// NCBI TaxId: 2641057
/// </summary>
public abstract class unclassified_Ascidiella : Ascidiella, Iunclassified_Ascidiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ascidiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641057;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ascidiella";
}
