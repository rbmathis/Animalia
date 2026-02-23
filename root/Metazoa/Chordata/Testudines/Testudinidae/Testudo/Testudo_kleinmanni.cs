namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Testudo;

/// <summary>
/// Species: Testudo kleinmanni
/// NCBI TaxId: 101700
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Testudo_kleinmanni : Testudo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Testudo kleinmanni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Testudo_kleinmanni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 101700;
}
