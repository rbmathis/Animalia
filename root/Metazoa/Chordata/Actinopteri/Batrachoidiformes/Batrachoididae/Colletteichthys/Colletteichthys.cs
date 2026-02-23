using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Colletteichthys;

/// <summary>
/// Abstract class for Colletteichthys (genus).
/// NCBI TaxId: 990953
/// </summary>
public abstract class Colletteichthys : Batrachoididae, IColletteichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colletteichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990953;

    /// <inheritdoc />
    public virtual string GenusName => "Colletteichthys";

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
