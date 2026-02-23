namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

/// <summary>
/// Species: Coturnix sp. DFP-1995
/// NCBI TaxId: 131087
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coturnix_sp_DFP_1995 : Coturnix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coturnix sp. DFP-1995";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coturnix_sp_DFP_1995";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 131087;
}
