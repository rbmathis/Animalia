namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Claudius;

/// <summary>
/// Species: Claudius angustatus
/// NCBI TaxId: 904233
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Claudius_angustatus : Claudius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Claudius angustatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Claudius_angustatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904233;
}
