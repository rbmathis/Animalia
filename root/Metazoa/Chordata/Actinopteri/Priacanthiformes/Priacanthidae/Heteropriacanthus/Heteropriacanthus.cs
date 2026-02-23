using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Heteropriacanthus;

/// <summary>
/// Abstract class for Heteropriacanthus (genus).
/// NCBI TaxId: 342440
/// </summary>
public abstract class Heteropriacanthus : Priacanthidae, IHeteropriacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteropriacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342440;

    /// <inheritdoc />
    public virtual string GenusName => "Heteropriacanthus";

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
