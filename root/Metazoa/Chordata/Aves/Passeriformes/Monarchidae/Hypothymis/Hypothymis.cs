using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Hypothymis;

/// <summary>
/// Abstract class for Hypothymis (genus).
/// NCBI TaxId: 107209
/// </summary>
public abstract class Hypothymis : Monarchidae, IHypothymis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypothymis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107209;

    /// <inheritdoc />
    public virtual string GenusName => "Hypothymis";

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
