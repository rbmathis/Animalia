using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Halobatrachus;

/// <summary>
/// Abstract class for Halobatrachus (genus).
/// NCBI TaxId: 101186
/// </summary>
public abstract class Halobatrachus : Batrachoididae, IHalobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101186;

    /// <inheritdoc />
    public virtual string GenusName => "Halobatrachus";

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
