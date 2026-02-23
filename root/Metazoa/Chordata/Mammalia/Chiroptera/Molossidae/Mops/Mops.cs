using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Mops;

/// <summary>
/// Abstract class for Mops (genus).
/// NCBI TaxId: 258862
/// </summary>
public abstract class Mops : Molossidae, IMops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258862;

    /// <inheritdoc />
    public virtual string GenusName => "Mops";

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
