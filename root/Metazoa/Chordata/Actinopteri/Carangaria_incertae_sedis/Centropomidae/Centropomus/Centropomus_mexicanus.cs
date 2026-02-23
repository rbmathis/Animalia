namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Centropomus;

/// <summary>
/// Species: Centropomus mexicanus
/// NCBI TaxId: 28804
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Centropomus_mexicanus : Centropomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Centropomus mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Centropomus_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28804;
}
