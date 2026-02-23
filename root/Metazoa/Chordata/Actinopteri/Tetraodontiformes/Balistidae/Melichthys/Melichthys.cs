using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Melichthys;

/// <summary>
/// Abstract class for Melichthys (genus).
/// NCBI TaxId: 94927
/// </summary>
public abstract class Melichthys : Balistidae, IMelichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94927;

    /// <inheritdoc />
    public virtual string GenusName => "Melichthys";

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
