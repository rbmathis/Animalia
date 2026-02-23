namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Mammalia;

/// <summary>
/// Species: Homo sapiens/Rattus norvegicus xenograft
/// NCBI TaxId: 1573476
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homo_sapiensRattus_norvegicus_xenograft : unclassified_Mammalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homo sapiens/Rattus norvegicus xenograft";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homo_sapiensRattus_norvegicus_xenograft";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1573476;
}
