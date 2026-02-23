using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Ghatsa;

/// <summary>
/// Abstract class for Ghatsa (genus).
/// NCBI TaxId: 2717885
/// </summary>
public abstract class Ghatsa : Balitoridae, IGhatsa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ghatsa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2717885;

    /// <inheritdoc />
    public virtual string GenusName => "Ghatsa";

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
