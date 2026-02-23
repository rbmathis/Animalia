using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossops;

/// <summary>
/// Abstract class for Molossops (genus).
/// NCBI TaxId: 249031
/// </summary>
public abstract class Molossops : Molossidae, IMolossops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Molossops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249031;

    /// <inheritdoc />
    public virtual string GenusName => "Molossops";

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
