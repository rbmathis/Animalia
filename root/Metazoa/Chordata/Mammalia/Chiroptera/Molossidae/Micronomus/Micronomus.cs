using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Micronomus;

/// <summary>
/// Abstract class for Micronomus (genus).
/// NCBI TaxId: 3371053
/// </summary>
public abstract class Micronomus : Molossidae, IMicronomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micronomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371053;

    /// <inheritdoc />
    public virtual string GenusName => "Micronomus";

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
