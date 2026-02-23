using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Potamogale;

/// <summary>
/// Abstract class for Potamogale (genus).
/// NCBI TaxId: 176118
/// </summary>
public abstract class Potamogale : Tenrecidae, IPotamogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176118;

    /// <inheritdoc />
    public virtual string GenusName => "Potamogale";

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
