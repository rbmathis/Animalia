using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Microstomatichthyoborus;

/// <summary>
/// Abstract class for Microstomatichthyoborus (genus).
/// NCBI TaxId: 1381078
/// </summary>
public abstract class Microstomatichthyoborus : Distichodontidae, IMicrostomatichthyoborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microstomatichthyoborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1381078;

    /// <inheritdoc />
    public virtual string GenusName => "Microstomatichthyoborus";

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
