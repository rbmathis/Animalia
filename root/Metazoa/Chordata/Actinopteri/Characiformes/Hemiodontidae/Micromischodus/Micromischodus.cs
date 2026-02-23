using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Micromischodus;

/// <summary>
/// Abstract class for Micromischodus (genus).
/// NCBI TaxId: 2742164
/// </summary>
public abstract class Micromischodus : Hemiodontidae, IMicromischodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromischodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2742164;

    /// <inheritdoc />
    public virtual string GenusName => "Micromischodus";

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
