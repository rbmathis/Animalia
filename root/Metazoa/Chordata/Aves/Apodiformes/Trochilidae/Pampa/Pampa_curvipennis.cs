namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Pampa;

/// <summary>
/// Species: Pampa curvipennis
/// NCBI TaxId: 3150280
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pampa_curvipennis : Pampa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pampa curvipennis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pampa_curvipennis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150280;
}
