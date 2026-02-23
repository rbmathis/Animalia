using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycaon;

/// <summary>
/// Abstract class for Lycaon (genus).
/// NCBI TaxId: 9621
/// </summary>
public abstract class Lycaon : Canidae, ILycaon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycaon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9621;

    /// <inheritdoc />
    public virtual string GenusName => "Lycaon";

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
