using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Metopidius;

/// <summary>
/// Abstract class for Metopidius (genus).
/// NCBI TaxId: 118787
/// </summary>
public abstract class Metopidius : Jacanidae, IMetopidius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metopidius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118787;

    /// <inheritdoc />
    public virtual string GenusName => "Metopidius";

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
