using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Atypichthys;

/// <summary>
/// Abstract class for Atypichthys (genus).
/// NCBI TaxId: 272789
/// </summary>
public abstract class Atypichthys : Kyphosidae, IAtypichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atypichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272789;

    /// <inheritdoc />
    public virtual string GenusName => "Atypichthys";

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
