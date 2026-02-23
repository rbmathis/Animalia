using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebuella;

/// <summary>
/// Abstract class for Cebuella (genus).
/// NCBI TaxId: 1965109
/// </summary>
public abstract class Cebuella : Cebidae, ICebuella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cebuella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1965109;

    /// <inheritdoc />
    public virtual string GenusName => "Cebuella";

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
