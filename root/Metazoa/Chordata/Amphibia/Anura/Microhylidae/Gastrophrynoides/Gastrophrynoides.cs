using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Gastrophrynoides;

/// <summary>
/// Abstract class for Gastrophrynoides (genus).
/// NCBI TaxId: 980596
/// </summary>
public abstract class Gastrophrynoides : Microhylidae, IGastrophrynoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastrophrynoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980596;

    /// <inheritdoc />
    public virtual string GenusName => "Gastrophrynoides";

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
