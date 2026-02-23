using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Glirulus;

/// <summary>
/// Abstract class for Glirulus (genus).
/// NCBI TaxId: 55146
/// </summary>
public abstract class Glirulus : Gliridae, IGlirulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glirulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55146;

    /// <inheritdoc />
    public virtual string GenusName => "Glirulus";

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
