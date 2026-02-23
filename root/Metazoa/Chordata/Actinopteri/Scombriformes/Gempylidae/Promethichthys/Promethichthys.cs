using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Promethichthys;

/// <summary>
/// Abstract class for Promethichthys (genus).
/// NCBI TaxId: 349643
/// </summary>
public abstract class Promethichthys : Gempylidae, IPromethichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Promethichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349643;

    /// <inheritdoc />
    public virtual string GenusName => "Promethichthys";

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
