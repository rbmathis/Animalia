using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Pseudosoriculus;

/// <summary>
/// Abstract class for Pseudosoriculus (genus).
/// NCBI TaxId: 3371083
/// </summary>
public abstract class Pseudosoriculus : Soricidae, IPseudosoriculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudosoriculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371083;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudosoriculus";

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
