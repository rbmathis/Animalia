using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Megalaspis;

/// <summary>
/// Abstract class for Megalaspis (genus).
/// NCBI TaxId: 232275
/// </summary>
public abstract class Megalaspis : Carangidae, IMegalaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232275;

    /// <inheritdoc />
    public virtual string GenusName => "Megalaspis";

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
