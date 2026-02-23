using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Chlorohyla;

/// <summary>
/// Abstract class for Chlorohyla (genus).
/// NCBI TaxId: 3680986
/// </summary>
public abstract class Chlorohyla : Pelodryadidae, IChlorohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680986;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorohyla";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
