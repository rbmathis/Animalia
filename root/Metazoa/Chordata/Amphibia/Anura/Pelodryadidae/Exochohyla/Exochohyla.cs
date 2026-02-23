using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Exochohyla;

/// <summary>
/// Abstract class for Exochohyla (genus).
/// NCBI TaxId: 3680993
/// </summary>
public abstract class Exochohyla : Pelodryadidae, IExochohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exochohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680993;

    /// <inheritdoc />
    public virtual string GenusName => "Exochohyla";

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
