namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

/// <summary>
/// Species: Chimaera sp.
/// NCBI TaxId: 30516
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chimaera_sp : Chimaera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chimaera sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chimaera_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30516;
}
