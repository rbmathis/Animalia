using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Miopithecus;

/// <summary>
/// Abstract class for Miopithecus (genus).
/// NCBI TaxId: 36230
/// </summary>
public abstract class Miopithecus : Cercopithecidae, IMiopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Miopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36230;

    /// <inheritdoc />
    public virtual string GenusName => "Miopithecus";

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
