namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius;

/// <summary>
/// Species: Squalius squalus
/// NCBI TaxId: 758553
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalius_squalus : Squalius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalius squalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalius_squalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 758553;
}
