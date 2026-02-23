using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Amanses;

/// <summary>
/// Abstract class for Amanses (genus).
/// NCBI TaxId: 245706
/// </summary>
public abstract class Amanses : Monacanthidae, IAmanses
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amanses";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245706;

    /// <inheritdoc />
    public virtual string GenusName => "Amanses";

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
