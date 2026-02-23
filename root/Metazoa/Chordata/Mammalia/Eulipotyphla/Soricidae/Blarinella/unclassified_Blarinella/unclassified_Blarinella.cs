using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Blarinella;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Blarinella.unclassified_Blarinella;

/// <summary>
/// Abstract class for unclassified Blarinella (no rank).
/// NCBI TaxId: 2624999
/// </summary>
public abstract class unclassified_Blarinella : Blarinella, Iunclassified_Blarinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blarinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624999;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blarinella";
}
