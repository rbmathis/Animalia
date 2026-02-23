using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Gorilla;

/// <summary>
/// Abstract class for Gorilla (genus).
/// NCBI TaxId: 9592
/// </summary>
public abstract class Gorilla : Hominidae, IGorilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gorilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9592;

    /// <inheritdoc />
    public virtual string GenusName => "Gorilla";

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
