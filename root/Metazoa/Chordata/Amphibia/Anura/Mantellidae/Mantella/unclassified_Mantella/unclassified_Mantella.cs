using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantella.unclassified_Mantella;

/// <summary>
/// Abstract class for unclassified Mantella (no rank).
/// NCBI TaxId: 410367
/// </summary>
public abstract class unclassified_Mantella : Mantella, Iunclassified_Mantella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mantella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 410367;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mantella";
}
