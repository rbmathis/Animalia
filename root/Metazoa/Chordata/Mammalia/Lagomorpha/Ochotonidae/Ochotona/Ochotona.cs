using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae.Ochotona;

/// <summary>
/// Abstract class for Ochotona (genus).
/// NCBI TaxId: 9977
/// </summary>
public abstract class Ochotona : Ochotonidae, IOchotona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ochotona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9977;

    /// <inheritdoc />
    public virtual string GenusName => "Ochotona";

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
