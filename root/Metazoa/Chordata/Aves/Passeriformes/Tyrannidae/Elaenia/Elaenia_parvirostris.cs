namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Elaenia;

/// <summary>
/// Species: Elaenia parvirostris
/// NCBI TaxId: 478600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elaenia_parvirostris : Elaenia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elaenia parvirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elaenia_parvirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 478600;
}
