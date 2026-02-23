namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polynemus;

/// <summary>
/// Species: Polynemus paradiseus
/// NCBI TaxId: 463598
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polynemus_paradiseus : Polynemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polynemus paradiseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polynemus_paradiseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 463598;
}
