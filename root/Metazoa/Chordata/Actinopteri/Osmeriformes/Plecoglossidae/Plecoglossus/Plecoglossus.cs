using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Plecoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Plecoglossidae.Plecoglossus;

/// <summary>
/// Abstract class for Plecoglossus (genus).
/// NCBI TaxId: 61083
/// </summary>
public abstract class Plecoglossus : Plecoglossidae, IPlecoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plecoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61083;

    /// <inheritdoc />
    public virtual string GenusName => "Plecoglossus";

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
