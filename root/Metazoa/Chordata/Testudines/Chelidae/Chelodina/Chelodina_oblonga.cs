namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina oblonga
/// NCBI TaxId: 44492
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_oblonga : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina oblonga";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_oblonga";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44492;
}
