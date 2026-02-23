using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Lophochroa;

/// <summary>
/// Abstract class for Lophochroa (genus).
/// NCBI TaxId: 2819877
/// </summary>
public abstract class Lophochroa : Cacatuidae, ILophochroa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophochroa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819877;

    /// <inheritdoc />
    public virtual string GenusName => "Lophochroa";

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
