namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Carollia;

/// <summary>
/// Species: Carollia brevicauda PS1
/// NCBI TaxId: 409058
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carollia_brevicauda_PS1 : Carollia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carollia brevicauda PS1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carollia_brevicauda_PS1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 409058;
}
