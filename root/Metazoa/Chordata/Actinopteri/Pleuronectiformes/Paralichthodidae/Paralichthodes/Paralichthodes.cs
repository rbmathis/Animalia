using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthodidae.Paralichthodes;

/// <summary>
/// Abstract class for Paralichthodes (genus).
/// NCBI TaxId: 1003978
/// </summary>
public abstract class Paralichthodes : Paralichthodidae, IParalichthodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralichthodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003978;

    /// <inheritdoc />
    public virtual string GenusName => "Paralichthodes";

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
