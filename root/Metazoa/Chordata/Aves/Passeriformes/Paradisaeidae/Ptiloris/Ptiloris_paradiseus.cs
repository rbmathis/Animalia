namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Ptiloris;

/// <summary>
/// Species: Ptiloris paradiseus
/// NCBI TaxId: 28720
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptiloris_paradiseus : Ptiloris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptiloris paradiseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptiloris_paradiseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28720;
}
