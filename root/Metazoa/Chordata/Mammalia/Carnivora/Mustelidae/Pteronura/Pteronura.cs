using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Pteronura;

/// <summary>
/// Abstract class for Pteronura (genus).
/// NCBI TaxId: 9671
/// </summary>
public abstract class Pteronura : Mustelidae, IPteronura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteronura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9671;

    /// <inheritdoc />
    public virtual string GenusName => "Pteronura";

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
