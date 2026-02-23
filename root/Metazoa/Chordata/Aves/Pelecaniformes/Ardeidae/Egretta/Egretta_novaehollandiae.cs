namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Egretta;

/// <summary>
/// Species: Egretta novaehollandiae
/// NCBI TaxId: 390973
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Egretta_novaehollandiae : Egretta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Egretta novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Egretta_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 390973;
}
