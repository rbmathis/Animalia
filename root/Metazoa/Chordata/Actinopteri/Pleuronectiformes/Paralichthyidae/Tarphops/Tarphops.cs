using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Tarphops;

/// <summary>
/// Abstract class for Tarphops (genus).
/// NCBI TaxId: 195654
/// </summary>
public abstract class Tarphops : Paralichthyidae, ITarphops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarphops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195654;

    /// <inheritdoc />
    public virtual string GenusName => "Tarphops";

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
