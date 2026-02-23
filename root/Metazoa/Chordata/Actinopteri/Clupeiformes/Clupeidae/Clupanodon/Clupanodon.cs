using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupanodon;

/// <summary>
/// Abstract class for Clupanodon (genus).
/// NCBI TaxId: 403223
/// </summary>
public abstract class Clupanodon : Clupeidae, IClupanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupanodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 403223;

    /// <inheritdoc />
    public virtual string GenusName => "Clupanodon";

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
