using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Thalassoica;

/// <summary>
/// Abstract class for Thalassoica (genus).
/// NCBI TaxId: 79658
/// </summary>
public abstract class Thalassoica : Procellariidae, IThalassoica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalassoica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79658;

    /// <inheritdoc />
    public virtual string GenusName => "Thalassoica";

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
