using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sauvagella;

/// <summary>
/// Abstract class for Sauvagella (genus).
/// NCBI TaxId: 521039
/// </summary>
public abstract class Sauvagella : Clupeidae, ISauvagella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sauvagella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521039;

    /// <inheritdoc />
    public virtual string GenusName => "Sauvagella";

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
