using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupeichthys;

/// <summary>
/// Abstract class for Clupeichthys (genus).
/// NCBI TaxId: 689639
/// </summary>
public abstract class Clupeichthys : Clupeidae, IClupeichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupeichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689639;

    /// <inheritdoc />
    public virtual string GenusName => "Clupeichthys";

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
