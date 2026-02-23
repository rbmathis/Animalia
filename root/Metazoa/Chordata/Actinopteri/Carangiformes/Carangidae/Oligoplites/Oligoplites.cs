using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Oligoplites;

/// <summary>
/// Abstract class for Oligoplites (genus).
/// NCBI TaxId: 173343
/// </summary>
public abstract class Oligoplites : Carangidae, IOligoplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligoplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173343;

    /// <inheritdoc />
    public virtual string GenusName => "Oligoplites";

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
