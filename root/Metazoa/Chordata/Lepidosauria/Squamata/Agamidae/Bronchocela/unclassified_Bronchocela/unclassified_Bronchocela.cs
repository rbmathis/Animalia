using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Bronchocela;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Bronchocela.unclassified_Bronchocela;

/// <summary>
/// Abstract class for unclassified Bronchocela (no rank).
/// NCBI TaxId: 3467898
/// </summary>
public abstract class unclassified_Bronchocela : Bronchocela, Iunclassified_Bronchocela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bronchocela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467898;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bronchocela";
}
