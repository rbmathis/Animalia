using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chiasmocleis;

/// <summary>
/// Abstract class for Chiasmocleis (genus).
/// NCBI TaxId: 445149
/// </summary>
public abstract class Chiasmocleis : Microhylidae, IChiasmocleis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiasmocleis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445149;

    /// <inheritdoc />
    public virtual string GenusName => "Chiasmocleis";

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
