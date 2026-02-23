using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptopsilotris;

/// <summary>
/// Abstract class for Cryptopsilotris (genus).
/// NCBI TaxId: 2008633
/// </summary>
public abstract class Cryptopsilotris : Gobiidae, ICryptopsilotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptopsilotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2008633;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptopsilotris";

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
