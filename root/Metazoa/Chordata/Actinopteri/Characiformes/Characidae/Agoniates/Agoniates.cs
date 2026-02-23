using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Agoniates;

/// <summary>
/// Abstract class for Agoniates (genus).
/// NCBI TaxId: 930282
/// </summary>
public abstract class Agoniates : Characidae, IAgoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930282;

    /// <inheritdoc />
    public virtual string GenusName => "Agoniates";

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
