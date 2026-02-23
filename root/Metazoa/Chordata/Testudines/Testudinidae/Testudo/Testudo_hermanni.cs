namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Testudo;

/// <summary>
/// Species: Testudo hermanni
/// NCBI TaxId: 86976
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Testudo_hermanni : Testudo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Testudo hermanni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Testudo_hermanni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 86976;
}
