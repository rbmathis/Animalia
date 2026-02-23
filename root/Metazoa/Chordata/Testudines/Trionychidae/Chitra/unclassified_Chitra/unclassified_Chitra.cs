using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Chitra;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Chitra.unclassified_Chitra;

/// <summary>
/// Abstract class for unclassified Chitra (no rank).
/// NCBI TaxId: 2622737
/// </summary>
public abstract class unclassified_Chitra : Chitra, Iunclassified_Chitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622737;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chitra";
}
