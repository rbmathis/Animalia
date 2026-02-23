using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Limnogale;

/// <summary>
/// Abstract class for Limnogale (genus).
/// NCBI TaxId: 319814
/// </summary>
public abstract class Limnogale : Tenrecidae, ILimnogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319814;

    /// <inheritdoc />
    public virtual string GenusName => "Limnogale";

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
