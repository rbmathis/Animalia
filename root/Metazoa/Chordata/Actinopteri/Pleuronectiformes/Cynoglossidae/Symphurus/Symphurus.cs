using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Symphurus;

/// <summary>
/// Abstract class for Symphurus (genus).
/// NCBI TaxId: 195651
/// </summary>
public abstract class Symphurus : Cynoglossidae, ISymphurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195651;

    /// <inheritdoc />
    public virtual string GenusName => "Symphurus";

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
