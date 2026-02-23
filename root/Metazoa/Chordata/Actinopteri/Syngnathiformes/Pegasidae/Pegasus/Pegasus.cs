using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Pegasus;

/// <summary>
/// Abstract class for Pegasus (genus).
/// NCBI TaxId: 215341
/// </summary>
public abstract class Pegasus : Pegasidae, IPegasus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pegasus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215341;

    /// <inheritdoc />
    public virtual string GenusName => "Pegasus";

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
