using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Pseudorhombus;

/// <summary>
/// Abstract class for Pseudorhombus (genus).
/// NCBI TaxId: 171415
/// </summary>
public abstract class Pseudorhombus : Paralichthyidae, IPseudorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171415;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorhombus";

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
