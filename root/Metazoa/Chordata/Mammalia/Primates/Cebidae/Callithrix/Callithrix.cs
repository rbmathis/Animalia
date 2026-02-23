using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callithrix;

/// <summary>
/// Abstract class for Callithrix (genus).
/// NCBI TaxId: 9481
/// </summary>
public abstract class Callithrix : Cebidae, ICallithrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callithrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9481;

    /// <inheritdoc />
    public virtual string GenusName => "Callithrix";

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
