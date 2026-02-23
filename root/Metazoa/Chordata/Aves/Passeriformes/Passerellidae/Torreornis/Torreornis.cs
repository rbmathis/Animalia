using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Torreornis;

/// <summary>
/// Abstract class for Torreornis (genus).
/// NCBI TaxId: 1271575
/// </summary>
public abstract class Torreornis : Passerellidae, ITorreornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Torreornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271575;

    /// <inheritdoc />
    public virtual string GenusName => "Torreornis";

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
