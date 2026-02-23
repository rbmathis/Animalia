namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Apus;

/// <summary>
/// Species: Apus pacificus
/// NCBI TaxId: 190670
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apus_pacificus : Apus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apus pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apus_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190670;
}
