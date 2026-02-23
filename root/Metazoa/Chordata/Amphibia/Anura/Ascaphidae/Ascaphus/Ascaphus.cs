using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ascaphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ascaphidae.Ascaphus;

/// <summary>
/// Abstract class for Ascaphus (genus).
/// NCBI TaxId: 8438
/// </summary>
public abstract class Ascaphus : Ascaphidae, IAscaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ascaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8438;

    /// <inheritdoc />
    public virtual string GenusName => "Ascaphus";

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
