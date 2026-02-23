using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptothorax;

/// <summary>
/// Abstract class for Glyptothorax (genus).
/// NCBI TaxId: 175779
/// </summary>
public abstract class Glyptothorax : Sisoridae, IGlyptothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175779;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptothorax";

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
