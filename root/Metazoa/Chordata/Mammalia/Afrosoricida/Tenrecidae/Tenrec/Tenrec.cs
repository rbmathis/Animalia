using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Tenrec;

/// <summary>
/// Abstract class for Tenrec (genus).
/// NCBI TaxId: 94438
/// </summary>
public abstract class Tenrec : Tenrecidae, ITenrec
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tenrec";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94438;

    /// <inheritdoc />
    public virtual string GenusName => "Tenrec";

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
