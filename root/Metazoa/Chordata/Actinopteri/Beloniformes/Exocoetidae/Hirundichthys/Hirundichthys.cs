using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Hirundichthys;

/// <summary>
/// Abstract class for Hirundichthys (genus).
/// NCBI TaxId: 76073
/// </summary>
public abstract class Hirundichthys : Exocoetidae, IHirundichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hirundichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76073;

    /// <inheritdoc />
    public virtual string GenusName => "Hirundichthys";

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
