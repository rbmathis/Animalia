using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Amietia;

/// <summary>
/// Abstract class for Amietia (genus).
/// NCBI TaxId: 164737
/// </summary>
public abstract class Amietia : Pyxicephalidae, IAmietia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amietia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164737;

    /// <inheritdoc />
    public virtual string GenusName => "Amietia";

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
