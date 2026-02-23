namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Sphyraenidae.Sphyraena;

/// <summary>
/// Species: Sphyraena ensis
/// NCBI TaxId: 740708
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyraena_ensis : Sphyraena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyraena ensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyraena_ensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 740708;
}
