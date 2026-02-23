using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Cleptornis;

/// <summary>
/// Abstract class for Cleptornis (genus).
/// NCBI TaxId: 43156
/// </summary>
public abstract class Cleptornis : Zosteropidae, ICleptornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cleptornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43156;

    /// <inheritdoc />
    public virtual string GenusName => "Cleptornis";

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
