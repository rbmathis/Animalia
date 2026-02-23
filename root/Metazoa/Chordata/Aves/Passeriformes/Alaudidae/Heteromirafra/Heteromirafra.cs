using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Heteromirafra;

/// <summary>
/// Abstract class for Heteromirafra (genus).
/// NCBI TaxId: 1365149
/// </summary>
public abstract class Heteromirafra : Alaudidae, IHeteromirafra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteromirafra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365149;

    /// <inheritdoc />
    public virtual string GenusName => "Heteromirafra";

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
