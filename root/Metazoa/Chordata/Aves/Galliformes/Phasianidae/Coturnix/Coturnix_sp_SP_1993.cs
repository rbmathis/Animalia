namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

/// <summary>
/// Species: Coturnix sp. SP-1993
/// NCBI TaxId: 131100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coturnix_sp_SP_1993 : Coturnix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coturnix sp. SP-1993";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coturnix_sp_SP_1993";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 131100;
}
