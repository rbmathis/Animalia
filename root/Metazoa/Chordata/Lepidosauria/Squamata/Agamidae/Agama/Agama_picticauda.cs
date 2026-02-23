namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama picticauda
/// NCBI TaxId: 1247906
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_picticauda : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama picticauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_picticauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1247906;
}
