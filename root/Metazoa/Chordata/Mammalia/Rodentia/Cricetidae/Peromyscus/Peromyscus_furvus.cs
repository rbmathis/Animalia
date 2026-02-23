namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus furvus
/// NCBI TaxId: 148310
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_furvus : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus furvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_furvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148310;
}
