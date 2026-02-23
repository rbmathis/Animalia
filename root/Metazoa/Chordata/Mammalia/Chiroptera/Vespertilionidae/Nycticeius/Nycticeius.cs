using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Nycticeius;

/// <summary>
/// Abstract class for Nycticeius (genus).
/// NCBI TaxId: 27669
/// </summary>
public abstract class Nycticeius : Vespertilionidae, INycticeius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nycticeius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27669;

    /// <inheritdoc />
    public virtual string GenusName => "Nycticeius";

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
