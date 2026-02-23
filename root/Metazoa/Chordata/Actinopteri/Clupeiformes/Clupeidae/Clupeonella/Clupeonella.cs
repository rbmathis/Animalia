using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupeonella;

/// <summary>
/// Abstract class for Clupeonella (genus).
/// NCBI TaxId: 501718
/// </summary>
public abstract class Clupeonella : Clupeidae, IClupeonella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupeonella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 501718;

    /// <inheritdoc />
    public virtual string GenusName => "Clupeonella";

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
