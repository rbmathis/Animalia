using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemitilapia;

/// <summary>
/// Abstract class for Hemitilapia (genus).
/// NCBI TaxId: 445557
/// </summary>
public abstract class Hemitilapia : Cichlidae, IHemitilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445557;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitilapia";

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
