using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontopithecus;

/// <summary>
/// Abstract class for Leontopithecus (genus).
/// NCBI TaxId: 30587
/// </summary>
public abstract class Leontopithecus : Cebidae, ILeontopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leontopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30587;

    /// <inheritdoc />
    public virtual string GenusName => "Leontopithecus";

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
