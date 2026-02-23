using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiozetetes;

/// <summary>
/// Abstract class for Myiozetetes (genus).
/// NCBI TaxId: 478634
/// </summary>
public abstract class Myiozetetes : Tyrannidae, IMyiozetetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiozetetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478634;

    /// <inheritdoc />
    public virtual string GenusName => "Myiozetetes";

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
