using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Tragulichthys;

/// <summary>
/// Abstract class for Tragulichthys (genus).
/// NCBI TaxId: 2578411
/// </summary>
public abstract class Tragulichthys : Diodontidae, ITragulichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tragulichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578411;

    /// <inheritdoc />
    public virtual string GenusName => "Tragulichthys";

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
