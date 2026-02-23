using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Nasalis;

/// <summary>
/// Abstract class for Nasalis (genus).
/// NCBI TaxId: 43779
/// </summary>
public abstract class Nasalis : Cercopithecidae, INasalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nasalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43779;

    /// <inheritdoc />
    public virtual string GenusName => "Nasalis";

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
