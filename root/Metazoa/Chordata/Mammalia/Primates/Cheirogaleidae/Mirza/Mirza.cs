using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Mirza;

/// <summary>
/// Abstract class for Mirza (genus).
/// NCBI TaxId: 83691
/// </summary>
public abstract class Mirza : Cheirogaleidae, IMirza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83691;

    /// <inheritdoc />
    public virtual string GenusName => "Mirza";

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
