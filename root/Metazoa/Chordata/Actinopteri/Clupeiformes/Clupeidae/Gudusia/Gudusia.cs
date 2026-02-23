using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Gudusia;

/// <summary>
/// Abstract class for Gudusia (genus).
/// NCBI TaxId: 691796
/// </summary>
public abstract class Gudusia : Clupeidae, IGudusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gudusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691796;

    /// <inheritdoc />
    public virtual string GenusName => "Gudusia";

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
