namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Eonycteris;

/// <summary>
/// Species: Eonycteris spelaea
/// NCBI TaxId: 58065
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eonycteris_spelaea : Eonycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eonycteris spelaea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eonycteris_spelaea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 58065;
}
