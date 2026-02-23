using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Rudarius;

/// <summary>
/// Abstract class for Rudarius (genus).
/// NCBI TaxId: 392930
/// </summary>
public abstract class Rudarius : Monacanthidae, IRudarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rudarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392930;

    /// <inheritdoc />
    public virtual string GenusName => "Rudarius";

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
