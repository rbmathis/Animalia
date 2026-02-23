using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lagurus;

/// <summary>
/// Abstract class for Lagurus (genus).
/// NCBI TaxId: 175521
/// </summary>
public abstract class Lagurus : Cricetidae, ILagurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175521;

    /// <inheritdoc />
    public virtual string GenusName => "Lagurus";

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
