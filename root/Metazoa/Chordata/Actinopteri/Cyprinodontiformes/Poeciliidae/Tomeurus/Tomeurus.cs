using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Tomeurus;

/// <summary>
/// Abstract class for Tomeurus (genus).
/// NCBI TaxId: 28753
/// </summary>
public abstract class Tomeurus : Poeciliidae, ITomeurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomeurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28753;

    /// <inheritdoc />
    public virtual string GenusName => "Tomeurus";

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
