namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Paracapoeta;

/// <summary>
/// Species: Paracapoeta trutta
/// NCBI TaxId: 116046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paracapoeta_trutta : Paracapoeta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paracapoeta trutta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paracapoeta_trutta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 116046;
}
