using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Microptilotis;

/// <summary>
/// Abstract class for Microptilotis (genus).
/// NCBI TaxId: 3150803
/// </summary>
public abstract class Microptilotis : Meliphagidae, IMicroptilotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microptilotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150803;

    /// <inheritdoc />
    public virtual string GenusName => "Microptilotis";

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
