namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Sphyraenidae.Sphyraena;

/// <summary>
/// Species: Sphyraena forsteri
/// NCBI TaxId: 392543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyraena_forsteri : Sphyraena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyraena forsteri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyraena_forsteri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 392543;
}
