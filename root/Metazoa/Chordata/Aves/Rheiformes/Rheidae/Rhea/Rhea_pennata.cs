namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Rheiformes.Rheidae.Rhea;

/// <summary>
/// Species: Rhea pennata
/// NCBI TaxId: 8795
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhea_pennata : Rhea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhea pennata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhea_pennata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8795;
}
