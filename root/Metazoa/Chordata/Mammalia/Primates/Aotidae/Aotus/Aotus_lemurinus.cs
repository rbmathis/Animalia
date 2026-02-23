namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus lemurinus
/// NCBI TaxId: 43147
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_lemurinus : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus lemurinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_lemurinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43147;
}
