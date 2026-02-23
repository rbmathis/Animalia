using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobionellus;

/// <summary>
/// Abstract class for Gobionellus (genus).
/// NCBI TaxId: 167446
/// </summary>
public abstract class Gobionellus : Gobiidae, IGobionellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobionellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167446;

    /// <inheritdoc />
    public virtual string GenusName => "Gobionellus";

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
