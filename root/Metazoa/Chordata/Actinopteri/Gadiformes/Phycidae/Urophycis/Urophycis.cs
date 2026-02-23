using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae.Urophycis;

/// <summary>
/// Abstract class for Urophycis (genus).
/// NCBI TaxId: 183655
/// </summary>
public abstract class Urophycis : Phycidae, IUrophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183655;

    /// <inheritdoc />
    public virtual string GenusName => "Urophycis";

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
