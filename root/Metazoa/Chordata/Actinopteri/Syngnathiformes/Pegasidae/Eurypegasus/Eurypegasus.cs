using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Eurypegasus;

/// <summary>
/// Abstract class for Eurypegasus (genus).
/// NCBI TaxId: 215338
/// </summary>
public abstract class Eurypegasus : Pegasidae, IEurypegasus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurypegasus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215338;

    /// <inheritdoc />
    public virtual string GenusName => "Eurypegasus";

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
