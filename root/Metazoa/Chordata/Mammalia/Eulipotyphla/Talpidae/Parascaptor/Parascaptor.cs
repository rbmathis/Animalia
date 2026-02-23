using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Parascaptor;

/// <summary>
/// Abstract class for Parascaptor (genus).
/// NCBI TaxId: 1300118
/// </summary>
public abstract class Parascaptor : Talpidae, IParascaptor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parascaptor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1300118;

    /// <inheritdoc />
    public virtual string GenusName => "Parascaptor";

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
