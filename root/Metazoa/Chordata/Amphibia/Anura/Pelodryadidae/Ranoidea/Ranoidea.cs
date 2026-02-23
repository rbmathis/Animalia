using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ranoidea;

/// <summary>
/// Abstract class for Ranoidea (genus).
/// NCBI TaxId: 2777416
/// </summary>
public abstract class Ranoidea : Pelodryadidae, IRanoidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ranoidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2777416;

    /// <inheritdoc />
    public virtual string GenusName => "Ranoidea";

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
