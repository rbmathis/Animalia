namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Osteolaemus;

/// <summary>
/// Species: Osteolaemus osborni
/// NCBI TaxId: 475781
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteolaemus_osborni : Osteolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteolaemus osborni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteolaemus_osborni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 475781;
}
