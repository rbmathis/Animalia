namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Dromaiidae.Dromaius;

/// <summary>
/// Species: Dromaius novaehollandiae
/// NCBI TaxId: 8790
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dromaius_novaehollandiae : Dromaius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dromaius novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dromaius_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8790;
}
