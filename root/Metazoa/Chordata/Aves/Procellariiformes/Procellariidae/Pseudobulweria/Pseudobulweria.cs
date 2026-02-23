using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pseudobulweria;

/// <summary>
/// Abstract class for Pseudobulweria (genus).
/// NCBI TaxId: 52127
/// </summary>
public abstract class Pseudobulweria : Procellariidae, IPseudobulweria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobulweria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52127;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobulweria";

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
