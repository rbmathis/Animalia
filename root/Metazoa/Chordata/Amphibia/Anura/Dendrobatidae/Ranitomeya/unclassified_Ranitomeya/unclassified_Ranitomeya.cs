using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ranitomeya;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ranitomeya.unclassified_Ranitomeya;

/// <summary>
/// Abstract class for unclassified Ranitomeya (no rank).
/// NCBI TaxId: 2627513
/// </summary>
public abstract class unclassified_Ranitomeya : Ranitomeya, Iunclassified_Ranitomeya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ranitomeya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627513;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ranitomeya";
}
