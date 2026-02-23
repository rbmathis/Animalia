using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pterodroma;

/// <summary>
/// Abstract class for Pterodroma (genus).
/// NCBI TaxId: 37063
/// </summary>
public abstract class Pterodroma : Procellariidae, IPterodroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterodroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37063;

    /// <inheritdoc />
    public virtual string GenusName => "Pterodroma";

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
