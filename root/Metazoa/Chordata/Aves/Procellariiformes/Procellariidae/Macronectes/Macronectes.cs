using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Macronectes;

/// <summary>
/// Abstract class for Macronectes (genus).
/// NCBI TaxId: 37056
/// </summary>
public abstract class Macronectes : Procellariidae, IMacronectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macronectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37056;

    /// <inheritdoc />
    public virtual string GenusName => "Macronectes";

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
