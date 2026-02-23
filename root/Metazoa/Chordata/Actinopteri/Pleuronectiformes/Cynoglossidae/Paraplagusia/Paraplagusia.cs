using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Paraplagusia;

/// <summary>
/// Abstract class for Paraplagusia (genus).
/// NCBI TaxId: 341732
/// </summary>
public abstract class Paraplagusia : Cynoglossidae, IParaplagusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraplagusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341732;

    /// <inheritdoc />
    public virtual string GenusName => "Paraplagusia";

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
