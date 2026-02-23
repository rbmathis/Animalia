namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mugilogobius;

/// <summary>
/// Species: Mugilogobius sp.
/// NCBI TaxId: 3112279
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mugilogobius_sp : Mugilogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mugilogobius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mugilogobius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3112279;
}
