using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Gurgesiellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Gurgesiellidae.Gurgesiella;

/// <summary>
/// Abstract class for Gurgesiella (genus).
/// NCBI TaxId: 117860
/// </summary>
public abstract class Gurgesiella : Gurgesiellidae, IGurgesiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gurgesiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117860;

    /// <inheritdoc />
    public virtual string GenusName => "Gurgesiella";

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
