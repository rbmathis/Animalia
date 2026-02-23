using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chiasmocleis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chiasmocleis.unclassified_Chiasmocleis;

/// <summary>
/// Abstract class for unclassified Chiasmocleis (no rank).
/// NCBI TaxId: 2685386
/// </summary>
public abstract class unclassified_Chiasmocleis : Chiasmocleis, Iunclassified_Chiasmocleis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiasmocleis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685386;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiasmocleis";
}
