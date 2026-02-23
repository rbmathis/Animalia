using AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae.Casuarius;

/// <summary>
/// Abstract class for Casuarius (genus).
/// NCBI TaxId: 8786
/// </summary>
public abstract class Casuarius : Casuariidae, ICasuarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Casuarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8786;

    /// <inheritdoc />
    public virtual string GenusName => "Casuarius";

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
