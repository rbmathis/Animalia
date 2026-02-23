namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor megacephalus
/// NCBI TaxId: 228431
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_megacephalus : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor megacephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_megacephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 228431;
}
