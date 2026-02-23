namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus;

/// <summary>
/// Species: Neobatrachus sp.
/// NCBI TaxId: 3243161
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neobatrachus_sp : Neobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neobatrachus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neobatrachus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3243161;
}
