using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tumbezia;

/// <summary>
/// Abstract class for Tumbezia (genus).
/// NCBI TaxId: 495217
/// </summary>
public abstract class Tumbezia : Tyrannidae, ITumbezia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tumbezia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495217;

    /// <inheritdoc />
    public virtual string GenusName => "Tumbezia";

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
