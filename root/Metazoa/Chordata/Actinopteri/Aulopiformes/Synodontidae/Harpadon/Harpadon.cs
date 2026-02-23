using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Harpadon;

/// <summary>
/// Abstract class for Harpadon (genus).
/// NCBI TaxId: 94309
/// </summary>
public abstract class Harpadon : Synodontidae, IHarpadon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpadon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94309;

    /// <inheritdoc />
    public virtual string GenusName => "Harpadon";

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
