using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Forcipiger;

/// <summary>
/// Abstract class for Forcipiger (genus).
/// NCBI TaxId: 109908
/// </summary>
public abstract class Forcipiger : Chaetodontidae, IForcipiger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Forcipiger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109908;

    /// <inheritdoc />
    public virtual string GenusName => "Forcipiger";

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
