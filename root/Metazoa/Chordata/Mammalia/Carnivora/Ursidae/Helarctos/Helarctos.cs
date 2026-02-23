using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Helarctos;

/// <summary>
/// Abstract class for Helarctos (genus).
/// NCBI TaxId: 9633
/// </summary>
public abstract class Helarctos : Ursidae, IHelarctos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helarctos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9633;

    /// <inheritdoc />
    public virtual string GenusName => "Helarctos";

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
