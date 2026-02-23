using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Herdmania;

/// <summary>
/// Abstract class for Herdmania (genus).
/// NCBI TaxId: 7732
/// </summary>
public abstract class Herdmania : Pyuridae, IHerdmania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herdmania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7732;

    /// <inheritdoc />
    public virtual string GenusName => "Herdmania";

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
