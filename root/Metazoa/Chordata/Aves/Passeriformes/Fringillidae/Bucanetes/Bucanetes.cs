using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Bucanetes;

/// <summary>
/// Abstract class for Bucanetes (genus).
/// NCBI TaxId: 589647
/// </summary>
public abstract class Bucanetes : Fringillidae, IBucanetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bucanetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589647;

    /// <inheritdoc />
    public virtual string GenusName => "Bucanetes";

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
