namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus mexicanus
/// NCBI TaxId: 56317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_mexicanus : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56317;
}
