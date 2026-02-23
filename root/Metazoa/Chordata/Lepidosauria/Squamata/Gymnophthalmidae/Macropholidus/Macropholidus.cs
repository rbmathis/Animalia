using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Macropholidus;

/// <summary>
/// Abstract class for Macropholidus (genus).
/// NCBI TaxId: 174751
/// </summary>
public abstract class Macropholidus : Gymnophthalmidae, IMacropholidus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macropholidus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174751;

    /// <inheritdoc />
    public virtual string GenusName => "Macropholidus";

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
