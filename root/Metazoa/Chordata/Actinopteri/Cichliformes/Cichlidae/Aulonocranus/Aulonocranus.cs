using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aulonocranus;

/// <summary>
/// Abstract class for Aulonocranus (genus).
/// NCBI TaxId: 27730
/// </summary>
public abstract class Aulonocranus : Cichlidae, IAulonocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulonocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27730;

    /// <inheritdoc />
    public virtual string GenusName => "Aulonocranus";

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
