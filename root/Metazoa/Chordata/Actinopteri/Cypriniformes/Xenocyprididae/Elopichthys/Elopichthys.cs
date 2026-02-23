using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Elopichthys;

/// <summary>
/// Abstract class for Elopichthys (genus).
/// NCBI TaxId: 238032
/// </summary>
public abstract class Elopichthys : Xenocyprididae, IElopichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elopichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238032;

    /// <inheritdoc />
    public virtual string GenusName => "Elopichthys";

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
