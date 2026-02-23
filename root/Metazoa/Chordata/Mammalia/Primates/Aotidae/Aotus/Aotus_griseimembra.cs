namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus griseimembra
/// NCBI TaxId: 292213
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_griseimembra : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus griseimembra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_griseimembra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 292213;
}
