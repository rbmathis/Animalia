using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Pteruthius;

/// <summary>
/// Abstract class for Pteruthius (genus).
/// NCBI TaxId: 201361
/// </summary>
public abstract class Pteruthius : Timaliidae, IPteruthius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteruthius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201361;

    /// <inheritdoc />
    public virtual string GenusName => "Pteruthius";

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
