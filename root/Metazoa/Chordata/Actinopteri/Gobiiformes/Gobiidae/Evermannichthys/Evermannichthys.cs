using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Evermannichthys;

/// <summary>
/// Abstract class for Evermannichthys (genus).
/// NCBI TaxId: 203303
/// </summary>
public abstract class Evermannichthys : Gobiidae, IEvermannichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evermannichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203303;

    /// <inheritdoc />
    public virtual string GenusName => "Evermannichthys";

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
