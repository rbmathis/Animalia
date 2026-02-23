using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Microcosmus;

/// <summary>
/// Abstract class for Microcosmus (genus).
/// NCBI TaxId: 341085
/// </summary>
public abstract class Microcosmus : Pyuridae, IMicrocosmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcosmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341085;

    /// <inheritdoc />
    public virtual string GenusName => "Microcosmus";

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
