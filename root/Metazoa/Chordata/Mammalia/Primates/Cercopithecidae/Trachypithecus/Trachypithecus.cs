using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

/// <summary>
/// Abstract class for Trachypithecus (genus).
/// NCBI TaxId: 54136
/// </summary>
public abstract class Trachypithecus : Cercopithecidae, ITrachypithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachypithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54136;

    /// <inheritdoc />
    public virtual string GenusName => "Trachypithecus";

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
