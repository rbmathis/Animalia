using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Verulux;

/// <summary>
/// Abstract class for Verulux (genus).
/// NCBI TaxId: 2204216
/// </summary>
public abstract class Verulux : Apogonidae, IVerulux
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Verulux";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2204216;

    /// <inheritdoc />
    public virtual string GenusName => "Verulux";

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
