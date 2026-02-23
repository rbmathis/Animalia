namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor sp. Pico Blanco
/// NCBI TaxId: 3345337
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_sp_Pico_Blanco : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor sp. Pico Blanco";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_sp_Pico_Blanco";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3345337;
}
