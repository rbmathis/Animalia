using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Phytichthys;

/// <summary>
/// Abstract class for Phytichthys (genus).
/// NCBI TaxId: 1738903
/// </summary>
public abstract class Phytichthys : Stichaeidae, IPhytichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phytichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1738903;

    /// <inheritdoc />
    public virtual string GenusName => "Phytichthys";

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
