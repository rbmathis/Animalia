using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiotheretes;

/// <summary>
/// Abstract class for Myiotheretes (genus).
/// NCBI TaxId: 495229
/// </summary>
public abstract class Myiotheretes : Tyrannidae, IMyiotheretes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiotheretes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495229;

    /// <inheritdoc />
    public virtual string GenusName => "Myiotheretes";

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
