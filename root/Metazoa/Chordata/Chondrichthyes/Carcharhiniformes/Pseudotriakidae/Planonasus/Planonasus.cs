using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Pseudotriakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Pseudotriakidae.Planonasus;

/// <summary>
/// Abstract class for Planonasus (genus).
/// NCBI TaxId: 2599777
/// </summary>
public abstract class Planonasus : Pseudotriakidae, IPlanonasus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Planonasus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599777;

    /// <inheritdoc />
    public virtual string GenusName => "Planonasus";

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
