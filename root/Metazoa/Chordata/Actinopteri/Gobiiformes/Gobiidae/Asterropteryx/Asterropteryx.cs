using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Asterropteryx;

/// <summary>
/// Abstract class for Asterropteryx (genus).
/// NCBI TaxId: 151712
/// </summary>
public abstract class Asterropteryx : Gobiidae, IAsterropteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asterropteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 151712;

    /// <inheritdoc />
    public virtual string GenusName => "Asterropteryx";

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
