using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Procolobus;

/// <summary>
/// Abstract class for Procolobus (genus).
/// NCBI TaxId: 164647
/// </summary>
public abstract class Procolobus : Cercopithecidae, IProcolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164647;

    /// <inheritdoc />
    public virtual string GenusName => "Procolobus";

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
