namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus gratus
/// NCBI TaxId: 97208
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_gratus : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus gratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_gratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 97208;
}
