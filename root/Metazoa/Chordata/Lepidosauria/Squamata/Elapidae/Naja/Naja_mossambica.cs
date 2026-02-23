namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja mossambica
/// NCBI TaxId: 8644
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_mossambica : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja mossambica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_mossambica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8644;
}
