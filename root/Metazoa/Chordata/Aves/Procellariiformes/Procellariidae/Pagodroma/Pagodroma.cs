using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pagodroma;

/// <summary>
/// Abstract class for Pagodroma (genus).
/// NCBI TaxId: 52125
/// </summary>
public abstract class Pagodroma : Procellariidae, IPagodroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagodroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52125;

    /// <inheritdoc />
    public virtual string GenusName => "Pagodroma";

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
