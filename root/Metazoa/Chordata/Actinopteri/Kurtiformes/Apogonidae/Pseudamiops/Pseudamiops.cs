using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pseudamiops;

/// <summary>
/// Abstract class for Pseudamiops (genus).
/// NCBI TaxId: 475183
/// </summary>
public abstract class Pseudamiops : Apogonidae, IPseudamiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudamiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 475183;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudamiops";

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
