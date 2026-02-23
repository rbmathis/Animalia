using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemiodontichthys;

/// <summary>
/// Abstract class for Hemiodontichthys (genus).
/// NCBI TaxId: 503145
/// </summary>
public abstract class Hemiodontichthys : Loricariidae, IHemiodontichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiodontichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503145;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiodontichthys";

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
