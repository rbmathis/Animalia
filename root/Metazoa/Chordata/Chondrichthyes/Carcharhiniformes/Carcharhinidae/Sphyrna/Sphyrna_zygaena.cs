namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Sphyrna;

/// <summary>
/// Species: Sphyrna zygaena
/// NCBI TaxId: 195335
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyrna_zygaena : Sphyrna
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyrna zygaena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyrna_zygaena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 195335;
}
