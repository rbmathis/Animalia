namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pitangus;

/// <summary>
/// Species: Pitangus sulphuratus
/// NCBI TaxId: 371930
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pitangus_sulphuratus : Pitangus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pitangus sulphuratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pitangus_sulphuratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 371930;
}
