using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Phedinopsis;

/// <summary>
/// Abstract class for Phedinopsis (genus).
/// NCBI TaxId: 3150796
/// </summary>
public abstract class Phedinopsis : Hirundinidae, IPhedinopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phedinopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150796;

    /// <inheritdoc />
    public virtual string GenusName => "Phedinopsis";

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
