namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Serranobatrachus;

/// <summary>
/// Species: Serranobatrachus sp.
/// NCBI TaxId: 3455611
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Serranobatrachus_sp : Serranobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Serranobatrachus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Serranobatrachus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3455611;
}
