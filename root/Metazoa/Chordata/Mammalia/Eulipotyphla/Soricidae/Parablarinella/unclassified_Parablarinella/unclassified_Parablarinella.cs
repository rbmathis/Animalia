using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Parablarinella;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Parablarinella.unclassified_Parablarinella;

/// <summary>
/// Abstract class for unclassified Parablarinella (no rank).
/// NCBI TaxId: 2981329
/// </summary>
public abstract class unclassified_Parablarinella : Parablarinella, Iunclassified_Parablarinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parablarinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2981329;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parablarinella";
}
