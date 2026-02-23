using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Pluvianellus;

/// <summary>
/// Abstract class for Pluvianellus (genus).
/// NCBI TaxId: 227227
/// </summary>
public abstract class Pluvianellus : Charadriidae, IPluvianellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pluvianellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227227;

    /// <inheritdoc />
    public virtual string GenusName => "Pluvianellus";

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
