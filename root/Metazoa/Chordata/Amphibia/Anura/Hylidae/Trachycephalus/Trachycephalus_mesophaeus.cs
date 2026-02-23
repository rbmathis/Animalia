namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus;

/// <summary>
/// Species: Trachycephalus mesophaeus
/// NCBI TaxId: 318375
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachycephalus_mesophaeus : Trachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachycephalus mesophaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachycephalus_mesophaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318375;
}
