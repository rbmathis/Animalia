using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Proeutropiichthys;

/// <summary>
/// Abstract class for Proeutropiichthys (genus).
/// NCBI TaxId: 2771937
/// </summary>
public abstract class Proeutropiichthys : Schilbidae, IProeutropiichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proeutropiichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2771937;

    /// <inheritdoc />
    public virtual string GenusName => "Proeutropiichthys";

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
