using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Freemanichthys;

/// <summary>
/// Abstract class for Freemanichthys (genus).
/// NCBI TaxId: 255534
/// </summary>
public abstract class Freemanichthys : Agonidae, IFreemanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Freemanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255534;

    /// <inheritdoc />
    public virtual string GenusName => "Freemanichthys";

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
