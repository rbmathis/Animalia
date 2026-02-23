namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Otaria;

/// <summary>
/// Species: Otaria byronia
/// NCBI TaxId: 161932
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otaria_byronia : Otaria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otaria byronia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otaria_byronia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161932;
}
