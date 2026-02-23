namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceiidae_incertae_sedis.Erosa;

/// <summary>
/// Species: Erosa erosa
/// NCBI TaxId: 2202286
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erosa_erosa : Erosa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erosa erosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erosa_erosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2202286;
}
