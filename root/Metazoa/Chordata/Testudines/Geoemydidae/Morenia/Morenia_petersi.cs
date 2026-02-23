namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Morenia;

/// <summary>
/// Species: Morenia petersi
/// NCBI TaxId: 766172
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Morenia_petersi : Morenia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Morenia petersi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Morenia_petersi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 766172;
}
