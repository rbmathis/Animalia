using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Laeviscutella;

/// <summary>
/// Abstract class for Laeviscutella (genus).
/// NCBI TaxId: 2934019
/// </summary>
public abstract class Laeviscutella : Clupeidae, ILaeviscutella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laeviscutella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2934019;

    /// <inheritdoc />
    public virtual string GenusName => "Laeviscutella";

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
