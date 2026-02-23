namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycare;

/// <summary>
/// Species: Pachycare flavogriseum
/// NCBI TaxId: 692111
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachycare_flavogriseum : Pachycare
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachycare flavogriseum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachycare_flavogriseum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 692111;
}
