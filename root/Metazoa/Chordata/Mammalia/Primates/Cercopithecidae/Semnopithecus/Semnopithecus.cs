using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus;

/// <summary>
/// Abstract class for Semnopithecus (genus).
/// NCBI TaxId: 88028
/// </summary>
public abstract class Semnopithecus : Cercopithecidae, ISemnopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semnopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88028;

    /// <inheritdoc />
    public virtual string GenusName => "Semnopithecus";

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
