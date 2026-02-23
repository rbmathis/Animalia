namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Branchiostoma;

/// <summary>
/// Species: Branchiostoma lanceolatum
/// NCBI TaxId: 7740
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branchiostoma_lanceolatum : Branchiostoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branchiostoma lanceolatum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branchiostoma_lanceolatum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7740;
}
