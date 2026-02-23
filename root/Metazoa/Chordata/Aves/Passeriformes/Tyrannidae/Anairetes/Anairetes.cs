using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Anairetes;

/// <summary>
/// Abstract class for Anairetes (genus).
/// NCBI TaxId: 74356
/// </summary>
public abstract class Anairetes : Tyrannidae, IAnairetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anairetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74356;

    /// <inheritdoc />
    public virtual string GenusName => "Anairetes";

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
