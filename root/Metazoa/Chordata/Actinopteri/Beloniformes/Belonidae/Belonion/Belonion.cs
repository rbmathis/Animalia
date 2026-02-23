using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Belonion;

/// <summary>
/// Abstract class for Belonion (genus).
/// NCBI TaxId: 105852
/// </summary>
public abstract class Belonion : Belonidae, IBelonion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belonion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 105852;

    /// <inheritdoc />
    public virtual string GenusName => "Belonion";

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
