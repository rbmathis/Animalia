using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Voay;

/// <summary>
/// Abstract class for Voay (genus).
/// NCBI TaxId: 2793279
/// </summary>
public abstract class Voay : Crocodylidae, IVoay
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Voay";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2793279;

    /// <inheritdoc />
    public virtual string GenusName => "Voay";

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
