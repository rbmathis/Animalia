namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Orthorhyncus;

/// <summary>
/// Species: Orthorhyncus cristatus
/// NCBI TaxId: 111988
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Orthorhyncus_cristatus : Orthorhyncus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Orthorhyncus cristatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Orthorhyncus_cristatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111988;
}
