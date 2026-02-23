namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Limnodynastes;

/// <summary>
/// Species: Limnodynastes salmini
/// NCBI TaxId: 39404
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Limnodynastes_salmini : Limnodynastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Limnodynastes salmini";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Limnodynastes_salmini";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39404;
}
