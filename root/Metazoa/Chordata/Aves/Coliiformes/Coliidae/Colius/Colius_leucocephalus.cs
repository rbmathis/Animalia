namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius;

/// <summary>
/// Species: Colius leucocephalus
/// NCBI TaxId: 57411
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colius_leucocephalus : Colius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colius leucocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colius_leucocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57411;
}
