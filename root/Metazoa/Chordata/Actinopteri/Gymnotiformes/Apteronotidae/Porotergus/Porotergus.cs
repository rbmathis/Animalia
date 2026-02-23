using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Porotergus;

/// <summary>
/// Abstract class for Porotergus (genus).
/// NCBI TaxId: 1740098
/// </summary>
public abstract class Porotergus : Apteronotidae, IPorotergus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porotergus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1740098;

    /// <inheritdoc />
    public virtual string GenusName => "Porotergus";

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
