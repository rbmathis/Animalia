using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pachyptila;

/// <summary>
/// Abstract class for Pachyptila (genus).
/// NCBI TaxId: 37058
/// </summary>
public abstract class Pachyptila : Procellariidae, IPachyptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37058;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyptila";

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
