namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor polaclavus
/// NCBI TaxId: 2975034
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_polaclavus : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor polaclavus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_polaclavus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2975034;
}
