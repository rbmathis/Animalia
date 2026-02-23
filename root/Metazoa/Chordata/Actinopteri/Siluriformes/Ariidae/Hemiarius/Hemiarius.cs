using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Hemiarius;

/// <summary>
/// Abstract class for Hemiarius (genus).
/// NCBI TaxId: 591302
/// </summary>
public abstract class Hemiarius : Ariidae, IHemiarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591302;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiarius";

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
