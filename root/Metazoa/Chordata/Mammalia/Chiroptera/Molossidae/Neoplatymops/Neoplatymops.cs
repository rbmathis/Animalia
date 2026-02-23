using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Neoplatymops;

/// <summary>
/// Abstract class for Neoplatymops (genus).
/// NCBI TaxId: 3111555
/// </summary>
public abstract class Neoplatymops : Molossidae, INeoplatymops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoplatymops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3111555;

    /// <inheritdoc />
    public virtual string GenusName => "Neoplatymops";

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
