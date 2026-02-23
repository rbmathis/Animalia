using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Narcine;

/// <summary>
/// Abstract class for Narcine (genus).
/// NCBI TaxId: 195315
/// </summary>
public abstract class Narcine : Narcinidae, INarcine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Narcine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195315;

    /// <inheritdoc />
    public virtual string GenusName => "Narcine";

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
