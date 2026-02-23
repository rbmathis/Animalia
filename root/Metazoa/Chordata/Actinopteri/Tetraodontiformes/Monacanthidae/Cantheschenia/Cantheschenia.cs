using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Cantheschenia;

/// <summary>
/// Abstract class for Cantheschenia (genus).
/// NCBI TaxId: 2578373
/// </summary>
public abstract class Cantheschenia : Monacanthidae, ICantheschenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cantheschenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578373;

    /// <inheritdoc />
    public virtual string GenusName => "Cantheschenia";

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
