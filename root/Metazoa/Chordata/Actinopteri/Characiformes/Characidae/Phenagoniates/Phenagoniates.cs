using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Phenagoniates;

/// <summary>
/// Abstract class for Phenagoniates (genus).
/// NCBI TaxId: 930368
/// </summary>
public abstract class Phenagoniates : Characidae, IPhenagoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenagoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930368;

    /// <inheritdoc />
    public virtual string GenusName => "Phenagoniates";

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
