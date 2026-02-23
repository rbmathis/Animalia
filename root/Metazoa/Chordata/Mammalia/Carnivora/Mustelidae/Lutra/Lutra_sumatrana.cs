namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lutra;

/// <summary>
/// Species: Lutra sumatrana
/// NCBI TaxId: 452642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lutra_sumatrana : Lutra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lutra sumatrana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lutra_sumatrana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 452642;
}
