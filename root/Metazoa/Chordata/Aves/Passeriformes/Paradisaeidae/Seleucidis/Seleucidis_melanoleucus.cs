namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Seleucidis;

/// <summary>
/// Species: Seleucidis melanoleucus
/// NCBI TaxId: 36265
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Seleucidis_melanoleucus : Seleucidis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Seleucidis melanoleucus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Seleucidis_melanoleucus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36265;
}
