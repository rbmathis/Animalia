namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Limnodynastes;

/// <summary>
/// Species: Limnodynastes depressus
/// NCBI TaxId: 104063
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Limnodynastes_depressus : Limnodynastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Limnodynastes depressus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Limnodynastes_depressus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 104063;
}
