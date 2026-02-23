using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Abstract class for Hylobates (genus).
/// NCBI TaxId: 9578
/// </summary>
public abstract class Hylobates : Hylobatidae, IHylobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9578;

    /// <inheritdoc />
    public virtual string GenusName => "Hylobates";

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
