namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor podiciferus
/// NCBI TaxId: 228448
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_podiciferus : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor podiciferus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_podiciferus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 228448;
}
