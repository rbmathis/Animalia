namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Ramphastos;

/// <summary>
/// Species: Ramphastos vitellinus
/// NCBI TaxId: 91793
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ramphastos_vitellinus : Ramphastos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ramphastos vitellinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ramphastos_vitellinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 91793;
}
