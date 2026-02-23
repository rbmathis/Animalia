namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Colluricincla;

/// <summary>
/// Species: Colluricincla tenebrosa
/// NCBI TaxId: 461231
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colluricincla_tenebrosa : Colluricincla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colluricincla tenebrosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colluricincla_tenebrosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 461231;
}
