using AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios.unclassified_Pelusios;

/// <summary>
/// Abstract class for unclassified Pelusios (no rank).
/// NCBI TaxId: 2637572
/// </summary>
public abstract class unclassified_Pelusios : Pelusios, Iunclassified_Pelusios
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelusios";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelusios";
}
