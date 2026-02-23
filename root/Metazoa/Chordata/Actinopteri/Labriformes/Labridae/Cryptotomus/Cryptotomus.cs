using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cryptotomus;

/// <summary>
/// Abstract class for Cryptotomus (genus).
/// NCBI TaxId: 90411
/// </summary>
public abstract class Cryptotomus : Labridae, ICryptotomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptotomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90411;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptotomus";

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
