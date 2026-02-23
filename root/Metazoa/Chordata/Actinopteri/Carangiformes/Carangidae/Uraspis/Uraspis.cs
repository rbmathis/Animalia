using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Uraspis;

/// <summary>
/// Abstract class for Uraspis (genus).
/// NCBI TaxId: 173316
/// </summary>
public abstract class Uraspis : Carangidae, IUraspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uraspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173316;

    /// <inheritdoc />
    public virtual string GenusName => "Uraspis";

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
