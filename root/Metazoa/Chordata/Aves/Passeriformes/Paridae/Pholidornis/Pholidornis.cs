using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Pholidornis;

/// <summary>
/// Abstract class for Pholidornis (genus).
/// NCBI TaxId: 208058
/// </summary>
public abstract class Pholidornis : Paridae, IPholidornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholidornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208058;

    /// <inheritdoc />
    public virtual string GenusName => "Pholidornis";

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
