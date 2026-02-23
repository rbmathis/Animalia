using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Rhinortha;

/// <summary>
/// Abstract class for Rhinortha (genus).
/// NCBI TaxId: 2478812
/// </summary>
public abstract class Rhinortha : Cuculidae, IRhinortha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinortha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2478812;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinortha";

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
