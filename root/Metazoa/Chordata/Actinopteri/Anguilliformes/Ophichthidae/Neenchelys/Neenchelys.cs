using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Neenchelys;

/// <summary>
/// Abstract class for Neenchelys (genus).
/// NCBI TaxId: 1405782
/// </summary>
public abstract class Neenchelys : Ophichthidae, INeenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405782;

    /// <inheritdoc />
    public virtual string GenusName => "Neenchelys";

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
