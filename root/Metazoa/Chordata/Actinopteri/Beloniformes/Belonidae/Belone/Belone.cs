using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Belone;

/// <summary>
/// Abstract class for Belone (genus).
/// NCBI TaxId: 129036
/// </summary>
public abstract class Belone : Belonidae, IBelone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129036;

    /// <inheritdoc />
    public virtual string GenusName => "Belone";

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
