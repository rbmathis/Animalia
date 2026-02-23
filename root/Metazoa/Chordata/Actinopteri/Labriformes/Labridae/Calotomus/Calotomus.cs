using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Calotomus;

/// <summary>
/// Abstract class for Calotomus (genus).
/// NCBI TaxId: 188111
/// </summary>
public abstract class Calotomus : Labridae, ICalotomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calotomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188111;

    /// <inheritdoc />
    public virtual string GenusName => "Calotomus";

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
