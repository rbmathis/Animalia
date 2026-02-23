using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Charmosyna;

/// <summary>
/// Abstract class for Charmosyna (genus).
/// NCBI TaxId: 176019
/// </summary>
public abstract class Charmosyna : Psittaculidae, ICharmosyna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charmosyna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176019;

    /// <inheritdoc />
    public virtual string GenusName => "Charmosyna";

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
