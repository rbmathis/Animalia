using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Prognichthys;

/// <summary>
/// Abstract class for Prognichthys (genus).
/// NCBI TaxId: 293904
/// </summary>
public abstract class Prognichthys : Exocoetidae, IPrognichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prognichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293904;

    /// <inheritdoc />
    public virtual string GenusName => "Prognichthys";

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
