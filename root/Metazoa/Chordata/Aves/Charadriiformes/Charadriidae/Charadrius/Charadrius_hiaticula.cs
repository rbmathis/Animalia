namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

/// <summary>
/// Species: Charadrius hiaticula
/// NCBI TaxId: 371911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Charadrius_hiaticula : Charadrius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Charadrius hiaticula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Charadrius_hiaticula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 371911;
}
