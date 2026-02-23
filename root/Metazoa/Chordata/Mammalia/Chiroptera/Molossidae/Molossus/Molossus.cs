using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossus;

/// <summary>
/// Abstract class for Molossus (genus).
/// NCBI TaxId: 27621
/// </summary>
public abstract class Molossus : Molossidae, IMolossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Molossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27621;

    /// <inheritdoc />
    public virtual string GenusName => "Molossus";

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
