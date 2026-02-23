namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Menidae.Mene;

/// <summary>
/// Species: Mene sp.
/// NCBI TaxId: 3446437
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mene_sp : Mene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mene sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mene_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3446437;
}
