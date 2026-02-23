using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Allomycterus;

/// <summary>
/// Abstract class for Allomycterus (genus).
/// NCBI TaxId: 303707
/// </summary>
public abstract class Allomycterus : Diodontidae, IAllomycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allomycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303707;

    /// <inheritdoc />
    public virtual string GenusName => "Allomycterus";

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
