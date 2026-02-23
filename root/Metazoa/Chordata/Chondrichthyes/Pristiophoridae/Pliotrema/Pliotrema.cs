using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae.Pliotrema;

/// <summary>
/// Abstract class for Pliotrema (genus).
/// NCBI TaxId: 990999
/// </summary>
public abstract class Pliotrema : Pristiophoridae, IPliotrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pliotrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990999;

    /// <inheritdoc />
    public virtual string GenusName => "Pliotrema";

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
