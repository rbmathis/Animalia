using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Omegophora;

/// <summary>
/// Abstract class for Omegophora (genus).
/// NCBI TaxId: 862800
/// </summary>
public abstract class Omegophora : Tetraodontidae, IOmegophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Omegophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862800;

    /// <inheritdoc />
    public virtual string GenusName => "Omegophora";

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
