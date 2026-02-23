using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Dayella;

/// <summary>
/// Abstract class for Dayella (genus).
/// NCBI TaxId: 2041888
/// </summary>
public abstract class Dayella : Clupeidae, IDayella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dayella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2041888;

    /// <inheritdoc />
    public virtual string GenusName => "Dayella";

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
