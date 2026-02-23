namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Cynictis;

/// <summary>
/// Species: Cynictis penicillata
/// NCBI TaxId: 41010
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cynictis_penicillata : Cynictis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cynictis penicillata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cynictis_penicillata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 41010;
}
