using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hypselecara;

/// <summary>
/// Abstract class for Hypselecara (genus).
/// NCBI TaxId: 74122
/// </summary>
public abstract class Hypselecara : Cichlidae, IHypselecara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypselecara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74122;

    /// <inheritdoc />
    public virtual string GenusName => "Hypselecara";

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
