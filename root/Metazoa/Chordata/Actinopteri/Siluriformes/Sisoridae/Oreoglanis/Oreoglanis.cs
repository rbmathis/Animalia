using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Oreoglanis;

/// <summary>
/// Abstract class for Oreoglanis (genus).
/// NCBI TaxId: 192194
/// </summary>
public abstract class Oreoglanis : Sisoridae, IOreoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192194;

    /// <inheritdoc />
    public virtual string GenusName => "Oreoglanis";

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
