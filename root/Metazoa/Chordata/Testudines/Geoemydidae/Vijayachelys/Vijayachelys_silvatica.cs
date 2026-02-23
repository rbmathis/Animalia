namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Vijayachelys;

/// <summary>
/// Species: Vijayachelys silvatica
/// NCBI TaxId: 332089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vijayachelys_silvatica : Vijayachelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vijayachelys silvatica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vijayachelys_silvatica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332089;
}
