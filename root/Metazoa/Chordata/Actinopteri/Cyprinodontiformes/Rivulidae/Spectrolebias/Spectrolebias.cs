using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Spectrolebias;

/// <summary>
/// Abstract class for Spectrolebias (genus).
/// NCBI TaxId: 941675
/// </summary>
public abstract class Spectrolebias : Rivulidae, ISpectrolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spectrolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941675;

    /// <inheritdoc />
    public virtual string GenusName => "Spectrolebias";

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
