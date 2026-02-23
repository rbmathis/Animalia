using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Aphelocoma;

/// <summary>
/// Abstract class for Aphelocoma (genus).
/// NCBI TaxId: 39616
/// </summary>
public abstract class Aphelocoma : Corvidae, IAphelocoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphelocoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39616;

    /// <inheritdoc />
    public virtual string GenusName => "Aphelocoma";

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
