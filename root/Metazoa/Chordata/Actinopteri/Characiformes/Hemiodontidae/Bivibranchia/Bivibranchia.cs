using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Bivibranchia;

/// <summary>
/// Abstract class for Bivibranchia (genus).
/// NCBI TaxId: 930300
/// </summary>
public abstract class Bivibranchia : Hemiodontidae, IBivibranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bivibranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930300;

    /// <inheritdoc />
    public virtual string GenusName => "Bivibranchia";

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
