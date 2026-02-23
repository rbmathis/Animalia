namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Ramphastos;

/// <summary>
/// Species: Ramphastos tucanus
/// NCBI TaxId: 125240
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ramphastos_tucanus : Ramphastos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ramphastos tucanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ramphastos_tucanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 125240;
}
