namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor persimilis
/// NCBI TaxId: 228453
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_persimilis : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor persimilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_persimilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 228453;
}
