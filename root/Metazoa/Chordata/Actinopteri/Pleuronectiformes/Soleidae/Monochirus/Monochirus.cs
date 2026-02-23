using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Monochirus;

/// <summary>
/// Abstract class for Monochirus (genus).
/// NCBI TaxId: 90075
/// </summary>
public abstract class Monochirus : Soleidae, IMonochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90075;

    /// <inheritdoc />
    public virtual string GenusName => "Monochirus";

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
