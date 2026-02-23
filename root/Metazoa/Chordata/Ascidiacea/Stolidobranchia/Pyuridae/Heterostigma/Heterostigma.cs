using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Heterostigma;

/// <summary>
/// Abstract class for Heterostigma (genus).
/// NCBI TaxId: 3386092
/// </summary>
public abstract class Heterostigma : Pyuridae, IHeterostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3386092;

    /// <inheritdoc />
    public virtual string GenusName => "Heterostigma";

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
