using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Paradisaea;

/// <summary>
/// Abstract class for Paradisaea (genus).
/// NCBI TaxId: 36266
/// </summary>
public abstract class Paradisaea : Paradisaeidae, IParadisaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradisaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36266;

    /// <inheritdoc />
    public virtual string GenusName => "Paradisaea";

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
