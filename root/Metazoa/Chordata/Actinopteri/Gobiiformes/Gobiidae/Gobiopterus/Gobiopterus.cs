using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiopterus;

/// <summary>
/// Abstract class for Gobiopterus (genus).
/// NCBI TaxId: 150302
/// </summary>
public abstract class Gobiopterus : Gobiidae, IGobiopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150302;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiopterus";

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
