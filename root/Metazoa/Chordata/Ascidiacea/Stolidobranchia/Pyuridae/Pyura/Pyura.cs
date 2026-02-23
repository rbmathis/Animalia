using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Pyura;

/// <summary>
/// Abstract class for Pyura (genus).
/// NCBI TaxId: 7730
/// </summary>
public abstract class Pyura : Pyuridae, IPyura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7730;

    /// <inheritdoc />
    public virtual string GenusName => "Pyura";

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
