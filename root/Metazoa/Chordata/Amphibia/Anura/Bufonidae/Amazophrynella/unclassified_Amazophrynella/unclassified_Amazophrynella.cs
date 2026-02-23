using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Amazophrynella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Amazophrynella.unclassified_Amazophrynella;

/// <summary>
/// Abstract class for unclassified Amazophrynella (no rank).
/// NCBI TaxId: 2645923
/// </summary>
public abstract class unclassified_Amazophrynella : Amazophrynella, Iunclassified_Amazophrynella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amazophrynella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amazophrynella";
}
