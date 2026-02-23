using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Cheilodipterus;

/// <summary>
/// Abstract class for Cheilodipterus (genus).
/// NCBI TaxId: 490317
/// </summary>
public abstract class Cheilodipterus : Apogonidae, ICheilodipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilodipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490317;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilodipterus";

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
