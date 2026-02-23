using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Meliarchus;

/// <summary>
/// Abstract class for Meliarchus (genus).
/// NCBI TaxId: 1439383
/// </summary>
public abstract class Meliarchus : Meliphagidae, IMeliarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meliarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1439383;

    /// <inheritdoc />
    public virtual string GenusName => "Meliarchus";

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
