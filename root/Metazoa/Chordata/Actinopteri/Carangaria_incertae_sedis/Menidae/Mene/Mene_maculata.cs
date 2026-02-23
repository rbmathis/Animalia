namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Menidae.Mene;

/// <summary>
/// Species: Mene maculata
/// NCBI TaxId: 206145
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mene_maculata : Mene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mene maculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mene_maculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 206145;
}
