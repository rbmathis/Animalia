using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Herpailurus;

/// <summary>
/// Abstract class for Herpailurus (genus).
/// NCBI TaxId: 61401
/// </summary>
public abstract class Herpailurus : Felidae, IHerpailurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herpailurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61401;

    /// <inheritdoc />
    public virtual string GenusName => "Herpailurus";

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
