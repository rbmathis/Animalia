namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer montanus
/// NCBI TaxId: 9160
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_montanus : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer montanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_montanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9160;
}
