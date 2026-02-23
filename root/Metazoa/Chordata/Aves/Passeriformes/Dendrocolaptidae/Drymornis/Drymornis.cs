using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Drymornis;

/// <summary>
/// Abstract class for Drymornis (genus).
/// NCBI TaxId: 183174
/// </summary>
public abstract class Drymornis : Dendrocolaptidae, IDrymornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183174;

    /// <inheritdoc />
    public virtual string GenusName => "Drymornis";

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
