using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Anhydrophryne;

/// <summary>
/// Abstract class for Anhydrophryne (genus).
/// NCBI TaxId: 143408
/// </summary>
public abstract class Anhydrophryne : Pyxicephalidae, IAnhydrophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anhydrophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143408;

    /// <inheritdoc />
    public virtual string GenusName => "Anhydrophryne";

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
