using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantella;

/// <summary>
/// Abstract class for Mantella (genus).
/// NCBI TaxId: 43513
/// </summary>
public abstract class Mantella : Mantellidae, IMantella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mantella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43513;

    /// <inheritdoc />
    public virtual string GenusName => "Mantella";

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
