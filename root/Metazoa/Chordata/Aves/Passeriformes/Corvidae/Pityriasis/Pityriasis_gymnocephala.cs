namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pityriasis;

/// <summary>
/// Species: Pityriasis gymnocephala
/// NCBI TaxId: 370837
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pityriasis_gymnocephala : Pityriasis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pityriasis gymnocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pityriasis_gymnocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 370837;
}
