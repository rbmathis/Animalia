namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus madrensis
/// NCBI TaxId: 97211
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_madrensis : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus madrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_madrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 97211;
}
