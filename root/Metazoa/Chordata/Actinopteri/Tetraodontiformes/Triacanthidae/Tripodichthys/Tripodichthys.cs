using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Tripodichthys;

/// <summary>
/// Abstract class for Tripodichthys (genus).
/// NCBI TaxId: 2746983
/// </summary>
public abstract class Tripodichthys : Triacanthidae, ITripodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tripodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2746983;

    /// <inheritdoc />
    public virtual string GenusName => "Tripodichthys";

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
