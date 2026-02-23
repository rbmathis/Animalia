using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

/// <summary>
/// Abstract class for Rhinopithecus (genus).
/// NCBI TaxId: 542827
/// </summary>
public abstract class Rhinopithecus : Cercopithecidae, IRhinopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 542827;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinopithecus";

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
