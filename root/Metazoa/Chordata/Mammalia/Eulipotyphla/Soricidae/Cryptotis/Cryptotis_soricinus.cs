namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Cryptotis;

/// <summary>
/// Species: Cryptotis soricinus
/// NCBI TaxId: 3345333
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptotis_soricinus : Cryptotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptotis soricinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptotis_soricinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3345333;
}
