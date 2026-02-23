namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis amplisquamosus
/// NCBI TaxId: 1920710
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_amplisquamosus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis amplisquamosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_amplisquamosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1920710;
}
