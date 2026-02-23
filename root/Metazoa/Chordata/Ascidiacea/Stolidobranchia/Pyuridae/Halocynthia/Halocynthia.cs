using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Halocynthia;

/// <summary>
/// Abstract class for Halocynthia (genus).
/// NCBI TaxId: 7728
/// </summary>
public abstract class Halocynthia : Pyuridae, IHalocynthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halocynthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7728;

    /// <inheritdoc />
    public virtual string GenusName => "Halocynthia";

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
