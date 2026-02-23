namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Plegadis;

/// <summary>
/// Species: Plegadis sp.
/// NCBI TaxId: 2489524
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plegadis_sp : Plegadis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plegadis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plegadis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2489524;
}
