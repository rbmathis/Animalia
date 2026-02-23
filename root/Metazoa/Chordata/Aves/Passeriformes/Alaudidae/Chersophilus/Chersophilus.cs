using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Chersophilus;

/// <summary>
/// Abstract class for Chersophilus (genus).
/// NCBI TaxId: 452473
/// </summary>
public abstract class Chersophilus : Alaudidae, IChersophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chersophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 452473;

    /// <inheritdoc />
    public virtual string GenusName => "Chersophilus";

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
