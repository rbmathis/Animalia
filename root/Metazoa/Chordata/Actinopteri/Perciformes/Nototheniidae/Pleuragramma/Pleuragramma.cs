using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Pleuragramma;

/// <summary>
/// Abstract class for Pleuragramma (genus).
/// NCBI TaxId: 101503
/// </summary>
public abstract class Pleuragramma : Nototheniidae, IPleuragramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuragramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101503;

    /// <inheritdoc />
    public virtual string GenusName => "Pleuragramma";

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
