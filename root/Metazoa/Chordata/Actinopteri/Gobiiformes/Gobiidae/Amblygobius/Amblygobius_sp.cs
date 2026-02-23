namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblygobius;

/// <summary>
/// Species: Amblygobius sp.
/// NCBI TaxId: 3439074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblygobius_sp : Amblygobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblygobius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblygobius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3439074;
}
