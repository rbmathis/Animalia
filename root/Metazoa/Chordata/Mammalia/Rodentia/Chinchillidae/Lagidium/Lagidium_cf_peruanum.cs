namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Lagidium;

/// <summary>
/// Species: Lagidium cf. peruanum
/// NCBI TaxId: 439226
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagidium_cf_peruanum : Lagidium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagidium cf. peruanum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagidium_cf_peruanum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 439226;
}
