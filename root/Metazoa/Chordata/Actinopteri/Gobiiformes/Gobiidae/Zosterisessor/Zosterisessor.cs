using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Zosterisessor;

/// <summary>
/// Abstract class for Zosterisessor (genus).
/// NCBI TaxId: 85427
/// </summary>
public abstract class Zosterisessor : Gobiidae, IZosterisessor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zosterisessor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85427;

    /// <inheritdoc />
    public virtual string GenusName => "Zosterisessor";

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
