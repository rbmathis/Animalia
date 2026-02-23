namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Melanochelys;

/// <summary>
/// Species: Melanochelys sp.
/// NCBI TaxId: 2018680
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melanochelys_sp : Melanochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melanochelys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melanochelys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2018680;
}
