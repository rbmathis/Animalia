using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Microbiotheria.Microbiotheriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Microbiotheria.Microbiotheriidae.Dromiciops;

/// <summary>
/// Abstract class for Dromiciops (genus).
/// NCBI TaxId: 33561
/// </summary>
public abstract class Dromiciops : Microbiotheriidae, IDromiciops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dromiciops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33561;

    /// <inheritdoc />
    public virtual string GenusName => "Dromiciops";

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
