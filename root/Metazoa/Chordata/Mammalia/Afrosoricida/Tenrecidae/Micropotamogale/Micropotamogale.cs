using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Micropotamogale;

/// <summary>
/// Abstract class for Micropotamogale (genus).
/// NCBI TaxId: 105688
/// </summary>
public abstract class Micropotamogale : Tenrecidae, IMicropotamogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropotamogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 105688;

    /// <inheritdoc />
    public virtual string GenusName => "Micropotamogale";

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
