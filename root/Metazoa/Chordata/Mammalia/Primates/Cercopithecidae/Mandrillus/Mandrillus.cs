using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Mandrillus;

/// <summary>
/// Abstract class for Mandrillus (genus).
/// NCBI TaxId: 9567
/// </summary>
public abstract class Mandrillus : Cercopithecidae, IMandrillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mandrillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9567;

    /// <inheritdoc />
    public virtual string GenusName => "Mandrillus";

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
