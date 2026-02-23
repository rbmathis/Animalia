using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Euoticus;

/// <summary>
/// Abstract class for Euoticus (genus).
/// NCBI TaxId: 261735
/// </summary>
public abstract class Euoticus : Galagidae, IEuoticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euoticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261735;

    /// <inheritdoc />
    public virtual string GenusName => "Euoticus";

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
