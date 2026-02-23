namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Centropomus;

/// <summary>
/// Species: Centropomus viridis
/// NCBI TaxId: 56564
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Centropomus_viridis : Centropomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Centropomus viridis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Centropomus_viridis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56564;
}
