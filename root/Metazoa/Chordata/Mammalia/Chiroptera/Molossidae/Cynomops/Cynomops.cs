using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Cynomops;

/// <summary>
/// Abstract class for Cynomops (genus).
/// NCBI TaxId: 303306
/// </summary>
public abstract class Cynomops : Molossidae, ICynomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303306;

    /// <inheritdoc />
    public virtual string GenusName => "Cynomops";

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
