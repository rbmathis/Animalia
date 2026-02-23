using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Hemiodus;

/// <summary>
/// Abstract class for Hemiodus (genus).
/// NCBI TaxId: 42501
/// </summary>
public abstract class Hemiodus : Hemiodontidae, IHemiodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42501;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiodus";

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
