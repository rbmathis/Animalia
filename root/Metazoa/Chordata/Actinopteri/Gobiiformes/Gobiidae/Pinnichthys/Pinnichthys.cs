using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pinnichthys;

/// <summary>
/// Abstract class for Pinnichthys (genus).
/// NCBI TaxId: 2008636
/// </summary>
public abstract class Pinnichthys : Gobiidae, IPinnichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinnichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2008636;

    /// <inheritdoc />
    public virtual string GenusName => "Pinnichthys";

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
