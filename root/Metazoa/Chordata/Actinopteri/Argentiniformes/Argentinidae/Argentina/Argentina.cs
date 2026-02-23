using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Argentina;

/// <summary>
/// Abstract class for Argentina (genus).
/// NCBI TaxId: 260511
/// </summary>
public abstract class Argentina : Argentinidae, IArgentina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argentina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260511;

    /// <inheritdoc />
    public virtual string GenusName => "Argentina";

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
