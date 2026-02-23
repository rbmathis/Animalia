using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Cyprinodon;

/// <summary>
/// Abstract class for Cyprinodon (genus).
/// NCBI TaxId: 28741
/// </summary>
public abstract class Cyprinodon : Cyprinodontidae, ICyprinodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28741;

    /// <inheritdoc />
    public virtual string GenusName => "Cyprinodon";

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
