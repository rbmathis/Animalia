using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Hippoglossina;

/// <summary>
/// Abstract class for Hippoglossina (genus).
/// NCBI TaxId: 455157
/// </summary>
public abstract class Hippoglossina : Paralichthyidae, IHippoglossina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippoglossina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 455157;

    /// <inheritdoc />
    public virtual string GenusName => "Hippoglossina";

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
