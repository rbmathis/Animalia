namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

/// <summary>
/// Species: Chimaera opalescens
/// NCBI TaxId: 469896
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chimaera_opalescens : Chimaera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chimaera opalescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chimaera_opalescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 469896;
}
