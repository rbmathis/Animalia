using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Priacanthus;

/// <summary>
/// Abstract class for Priacanthus (genus).
/// NCBI TaxId: 270571
/// </summary>
public abstract class Priacanthus : Priacanthidae, IPriacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270571;

    /// <inheritdoc />
    public virtual string GenusName => "Priacanthus";

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
