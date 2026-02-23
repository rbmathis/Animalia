using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Yongeichthys;

/// <summary>
/// Abstract class for Yongeichthys (genus).
/// NCBI TaxId: 1515622
/// </summary>
public abstract class Yongeichthys : Gobiidae, IYongeichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yongeichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1515622;

    /// <inheritdoc />
    public virtual string GenusName => "Yongeichthys";

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
