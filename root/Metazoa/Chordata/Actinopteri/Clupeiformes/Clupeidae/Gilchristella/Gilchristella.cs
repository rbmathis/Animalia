using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Gilchristella;

/// <summary>
/// Abstract class for Gilchristella (genus).
/// NCBI TaxId: 521028
/// </summary>
public abstract class Gilchristella : Clupeidae, IGilchristella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gilchristella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521028;

    /// <inheritdoc />
    public virtual string GenusName => "Gilchristella";

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
