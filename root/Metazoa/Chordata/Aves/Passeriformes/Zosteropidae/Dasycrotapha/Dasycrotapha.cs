using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Dasycrotapha;

/// <summary>
/// Abstract class for Dasycrotapha (genus).
/// NCBI TaxId: 2592505
/// </summary>
public abstract class Dasycrotapha : Zosteropidae, IDasycrotapha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasycrotapha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2592505;

    /// <inheritdoc />
    public virtual string GenusName => "Dasycrotapha";

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
