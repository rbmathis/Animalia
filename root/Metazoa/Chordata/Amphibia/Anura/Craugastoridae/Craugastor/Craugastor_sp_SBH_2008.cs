namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Species: Craugastor sp. SBH-2008
/// NCBI TaxId: 491130
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craugastor_sp_SBH_2008 : Craugastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craugastor sp. SBH-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craugastor_sp_SBH_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 491130;
}
