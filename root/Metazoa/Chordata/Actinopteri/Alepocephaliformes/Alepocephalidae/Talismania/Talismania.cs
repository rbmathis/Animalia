using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Talismania;

/// <summary>
/// Abstract class for Talismania (genus).
/// NCBI TaxId: 492048
/// </summary>
public abstract class Talismania : Alepocephalidae, ITalismania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Talismania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 492048;

    /// <inheritdoc />
    public virtual string GenusName => "Talismania";

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
