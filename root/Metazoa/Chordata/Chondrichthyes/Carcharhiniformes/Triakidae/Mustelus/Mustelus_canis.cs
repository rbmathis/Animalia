namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Mustelus;

/// <summary>
/// Species: Mustelus canis
/// NCBI TaxId: 7812
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustelus_canis : Mustelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustelus canis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustelus_canis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7812;
}
