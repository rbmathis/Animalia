namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tachymenis;

/// <summary>
/// Species: Tachymenis peruviana
/// NCBI TaxId: 666120
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachymenis_peruviana : Tachymenis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachymenis peruviana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachymenis_peruviana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 666120;
}
