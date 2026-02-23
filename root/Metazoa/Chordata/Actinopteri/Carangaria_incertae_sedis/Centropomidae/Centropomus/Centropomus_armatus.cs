namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Centropomus;

/// <summary>
/// Species: Centropomus armatus
/// NCBI TaxId: 56558
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Centropomus_armatus : Centropomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Centropomus armatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Centropomus_armatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56558;
}
