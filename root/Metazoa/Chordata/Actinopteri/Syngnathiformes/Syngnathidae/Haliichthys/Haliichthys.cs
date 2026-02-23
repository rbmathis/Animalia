using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Haliichthys;

/// <summary>
/// Abstract class for Haliichthys (genus).
/// NCBI TaxId: 864801
/// </summary>
public abstract class Haliichthys : Syngnathidae, IHaliichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haliichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 864801;

    /// <inheritdoc />
    public virtual string GenusName => "Haliichthys";

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
