namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Species: Tringa melanoleuca
/// NCBI TaxId: 161682
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tringa_melanoleuca : Tringa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tringa melanoleuca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tringa_melanoleuca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161682;
}
