using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Simias;

/// <summary>
/// Abstract class for Simias (genus).
/// NCBI TaxId: 1203020
/// </summary>
public abstract class Simias : Cercopithecidae, ISimias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1203020;

    /// <inheritdoc />
    public virtual string GenusName => "Simias";

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
