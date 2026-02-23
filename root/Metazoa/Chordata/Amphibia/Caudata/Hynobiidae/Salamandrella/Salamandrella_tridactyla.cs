namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Salamandrella;

/// <summary>
/// Species: Salamandrella tridactyla
/// NCBI TaxId: 476251
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salamandrella_tridactyla : Salamandrella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salamandrella tridactyla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salamandrella_tridactyla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 476251;
}
