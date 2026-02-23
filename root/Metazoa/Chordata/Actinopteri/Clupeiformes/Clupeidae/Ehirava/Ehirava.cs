using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Ehirava;

/// <summary>
/// Abstract class for Ehirava (genus).
/// NCBI TaxId: 689648
/// </summary>
public abstract class Ehirava : Clupeidae, IEhirava
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ehirava";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689648;

    /// <inheritdoc />
    public virtual string GenusName => "Ehirava";

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
