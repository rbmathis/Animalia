using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polyzoa;

/// <summary>
/// Abstract class for Polyzoa (genus).
/// NCBI TaxId: 581071
/// </summary>
public abstract class Polyzoa : Styelidae, IPolyzoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyzoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 581071;

    /// <inheritdoc />
    public virtual string GenusName => "Polyzoa";

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
