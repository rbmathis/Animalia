using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptosternon;

/// <summary>
/// Abstract class for Glyptosternon (genus).
/// NCBI TaxId: 175777
/// </summary>
public abstract class Glyptosternon : Sisoridae, IGlyptosternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptosternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175777;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptosternon";

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
